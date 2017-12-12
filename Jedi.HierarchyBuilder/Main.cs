using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Jedi.HierarchyBuilder.Entities;
using Jedi.HierarchyBuilder.Forms;
using Jedi.HierarchyBuilder.Logging;
using Jedi.HierarchyBuilder.Properties;
using Jedi.HierarchyBuilder.Utils;
using Jedi.HierarchyBuilder.Utils.Binder;
using Jedi.HierarchyBuilder.Utils.Binder.Validators;
using Jedi.HierarchyBuilder.Utils.Drawer;
using Jedi.HierarchyBuilder.Utils.Services;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Jedi.HierarchyBuilder
{
    public sealed partial class Main : Form
    {
        #region Enums

        public enum TreeHierarchyIcons : short
        {
            None = 0,
            Ghost = 1,
            Module = 2,
            Number
        }
        

        #endregion

        #region Constants

        private const string BASE_TITLE = "Jedi - Hierearcy Builder";
        private const string UNSAVED_MARK = " *";

        #endregion

        #region Fields

        private readonly ILog _logger;

        private IBinder _binder;
        private IBinderTracker _tracker;
        private bool _haveChanges;
        private string _fileHandled;
        private static int _idCounter;
        private readonly IconDrawer _drawer;
        private readonly RootOrganisationModel _rootOrganisationModel;
        private IList<RecentProject> _projects;

        private static readonly JsonSerializerSettings _jsonSettings;

        #endregion

        #region Properties

        private bool HaveChanges
        {
            get
            {
                return _haveChanges;
            }
            set
            {
                _haveChanges = value;
                SetTitle();
            }
        }

        private string FileHandledName => string.IsNullOrEmpty(_fileHandled) ? string.Empty : Path.GetFileName(_fileHandled);

        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();

            _logger = new Logger(WriteLog);
            _drawer = new IconDrawer
            {
                BackgroundColor = Color.Transparent,
                ForegroundColor = Color.Red,
                Size = new Size(16, 16),
                DrawingFont = new Font(Font, FontStyle.Bold)
            };
            _rootOrganisationModel = new RootOrganisationModel();
        }

        static Main()
        {
            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        #endregion

        #region Event handlers

        private async void Main_Load(object sender, EventArgs e)
        {
            await LoadUi();
            CreateBindings();
            tvHierarchy.SelectedNode = tvHierarchy.Nodes[0];

            LoadRecentProjects();
        }

        private async void btnApiUrl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show(this, "Api URL cannot be empty", BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.ApiUrl = txtUrl.Text;
            Settings.Default.Save();

            _logger.Write("Api URL changed");

            if (!string.IsNullOrEmpty(txtAuthorization.Text))
                await LoadApiInfo();
        }

        private async void btnOrgRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthorization.Text))
            {
                MessageBox.Show(this, "In order to load organisations authorization field must be completed", 
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await LoadApiInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiAddContainer_Click(object sender, EventArgs e)
        {
            CreateLa(false);
        }

        private void tsmiAddContent_Click(object sender, EventArgs e)
        {
            CreateLa(true);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedLearningActivity(sender is ToolStripButton);
        }
        
        private void tsmiMoveUp_Click(object sender, EventArgs e)
        {
            var node = tvHierarchy.SelectedNode;

            if(node == null || node.Level <= 0 || node.Index <= 0)
                return;

            node.MoveUp();
            tvHierarchy.SelectedNode = node;
        }

        private void tsmiMoveDown_Click(object sender, EventArgs e)
        {
            var node = tvHierarchy.SelectedNode;

            if (node == null || node.Level <= 0 || node.Parent == null || node.Index >= node.Parent.Nodes.Count - 1)
                return;

            node.MoveDown();
            tvHierarchy.SelectedNode = node;
        }

        private void tsmiMoveIn_Click(object sender, EventArgs e)
        {
            var node = tvHierarchy.SelectedNode;

            if(node == null || node.Level <= 0 || (GetNodeLearningActivity(node.PrevNode)?.IsActivity ?? true) || node.Parent == null)
                return;

            var item = GetNodeLearningActivity(node);
            var newParent = GetNodeLearningActivity(node.PrevNode);
            item.ParentRelation.ParentRelationId = newParent.Id;

            var newParentNode = node.PrevNode;

            node.Parent.Nodes.Remove(node);
            newParentNode.Nodes.Add(node);
            newParentNode.Expand();
            tvHierarchy.SelectedNode = node;
        }

        private void tsmiMoveOut_Click(object sender, EventArgs e)
        {
            var node = tvHierarchy.SelectedNode;

            if (node == null || node.Level <= 0 || node.Parent?.Parent == null)
                return;
            
            var item = GetNodeLearningActivity(node);
            var newParent = GetNodeLearningActivity(node.Parent.Parent);
            item.ParentRelation.ParentRelationId = newParent?.Id ?? 0;

            var newParentNode = node.Parent.Parent;
            var oldParentNode = node.Parent;
            node.Parent.Nodes.Remove(node);
            newParentNode.Nodes.Insert(oldParentNode.Index + 1, node);
            newParentNode.Expand();
            tvHierarchy.SelectedNode = node;
        }

        private void cmsHierarcy_Opening(object sender, CancelEventArgs e)
        {
            var selectedIsUpperLevel = (tvHierarchy.SelectedNode?.Level ?? -1) > 0;
            var isActivity = !GetSelectedLearningActivity()?.IsActivity ?? false;
            tsmiDelete.Enabled = selectedIsUpperLevel;
            tsmiAddContent.Enabled =
                tsmiAddContainer.Enabled =!selectedIsUpperLevel || isActivity;

            var node = tvHierarchy.SelectedNode;

            if (node != null)
            {
                tsmiMove.Enabled = node.Level > 0;
                tsmiMoveUp.Enabled = node.Index > 0;
                tsmiMoveDown.Enabled = node.Parent != null && node.Index < node.Parent.Nodes.Count - 1;
                tsmiMoveIn.Enabled = node.Index > 0 && (!GetNodeLearningActivity(node.PrevNode)?.IsActivity ?? false);
                tsmiMoveOut.Enabled = node.Level > 1 && node.Parent?.Parent != null;
            }
        }

        private void tvHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = tvHierarchy.SelectedNode;

            tpGeneral.Text = node?.Text ?? "General";
            tpGeneral.Enabled = 
                tpProvider.Enabled = 
                tpDisplaySettings.Enabled = 
                tpPolicy.Enabled = (node?.Level ?? -1) > 0;

            SetFieldsEnabled();

            lblPath.Text = GetPath();

            _binder.Set();

            if (node != null)
            {
                tsmiMove.Enabled = node.Level > 0;

                tsbMoveUp.Enabled = node.Index > 0;

                tsbMoveDown.Enabled = node.Parent != null && node.Index < node.Parent.Nodes.Count - 1;

                tsbMoveIn.Enabled = node.Index > 0 && (!GetNodeLearningActivity(node.PrevNode)?.IsActivity ?? false);

                tsbMoveOut.Enabled = node.Level > 1 && node.Parent?.Parent != null;

                tsbDelete.Enabled = node.Level > 0;
            }
        }

        private void tmrShowLastAction_Tick(object sender, EventArgs e)
        {
            tmrShowLastAction.Stop();
            tssiData.Text = string.Empty;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendHierarchy();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            ShowJsonForm();
        }

        private void viewHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowJsonForm();
        }

        private void tsmiEditUndo_Click(object sender, EventArgs e)
        {
            _tracker?.Undo();
        }

        private void tsmiEditRedo_Click(object sender, EventArgs e)
        {
            _tracker?.Redo();
        }

        private void tvHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                tvHierarchy.SelectedNode = e.Node;
        }

        private void tsmiFileNew_Click(object sender, EventArgs e)
        {
            if (HaveChanges)
            {
                var response = MessageBox.Show(this, "Your hierarcy have unsaved changes, are you sure you want to remove it?", 
                                               BASE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(response == DialogResult.No)
                    return;
            }

            try
            {
                tvHierarchy.BeginUpdate();
                tvHierarchy.Nodes[0].Nodes.Clear();
                tvHierarchy.SelectedNode = tvHierarchy.Nodes[0];

                HaveChanges = false;

                tvHierarchy_AfterSelect(tvHierarchy, new TreeViewEventArgs(tvHierarchy.SelectedNode, TreeViewAction.Unknown));
            }
            finally
            {
                tvHierarchy.EndUpdate();
            }
        }

        private void tsmiFileSave_Click(object sender, EventArgs e)
        {
            SaveHierarchy();
        }

        private void tsmiFileImport_Click(object sender, EventArgs e)
        {
            DialogResult response;
            if (HaveChanges)
            {
                response = MessageBox.Show(this, "Your hierarcy have unsaved changes, importing another hierarchy will overwrite all the unsaved changes" +
                                                 "Are you sure you want to continue?",
                                           BASE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.No)
                    return;
            }

            response = ofdImport.ShowDialog(this);

            if(response != DialogResult.OK)
                return;

            var text = File.ReadAllText(ofdImport.FileName);

            var root = JsonConvert.DeserializeObject<RootActivity>(text, _jsonSettings);

            ImportHierarchy(root);

            _fileHandled = ofdImport.FileName;

            HaveChanges = false;
        }

        private void tsmiHierarcyAddContent_Click(object sender, EventArgs e)
        {
            CreateLa(true);
        }

        private void tsmiHierarcyAddContainer_Click(object sender, EventArgs e)
        {
            CreateLa(false);
        }

        private void tsmiHierarcyDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedLearningActivity(false);
        }

        private async void tsmiHierarcySend_Click(object sender, EventArgs e)
        {
            await SendHierarchy();
        }

        private void tsmiHelpHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "No help for you :P", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!HaveChanges || e.CloseReason != CloseReason.UserClosing)
                return;

            var response = MessageBox.Show(this, "Your hierarcy have unsaved changes, do you want to save all?",
                                           BASE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response != DialogResult.Yes)
                return;

            if (!SaveHierarchy())
                e.Cancel = true;
        }

        #endregion

        #region Private methods

        private async Task LoadUi()
        {
            WinApi.SetExplorerTheme(tvHierarchy);

            FillCb();

            CreateImages();
            txtUrl.Text = Settings.Default.ApiUrl;
            await LoadApiInfo(false);

            _logger.Write("Ui Loaded");
        }

        private async Task LoadApiInfo(bool rethrowException = true)
        {
            try
            {
                if (string.IsNullOrEmpty(Settings.Default.ApiUrl) || string.IsNullOrEmpty(txtAuthorization.Text))
                    return;

                tsProgress.Visible = true;

                _logger.Write("Retriving organisations");

                var service = new OrganisationService(txtUrl.Text);

                var result = await service.Get(txtAuthorization.Text);

                try
                {
                    cbOrganisations.BeginUpdate();

                    cbOrganisations.Items.Clear();
                    cbOrganisations.Items.AddRange(result.Cast<object>().ToArray());

                    if (cbOrganisations.Items.Count > 0)
                        cbOrganisations.SelectedIndex = 0;
                    
                    _logger.Write($"{cbOrganisations.Items.Count} organisation retrived");
                }
                finally
                {
                    cbOrganisations.EndUpdate();
                }
            }
            catch (Exception)
            {
                _logger.Write("Fail to load organisations");
                if (rethrowException)
                    throw;
            }
            finally
            {
                tsProgress.Visible = false;
            }
        }

        private void LoadRecentProjects()
        {
            if(_projects == null)
            {
                try
                {
                    _projects = !string.IsNullOrEmpty(Settings.Default.RecentProjects) 
                                    ? JsonConvert.DeserializeObject<IList<RecentProject>>(Settings.Default.RecentProjects) 
                                    : new List<RecentProject>();
                }
                catch
#if DEBUG
                (Exception e)
#endif
                {
                    _logger.Write("Projects cannot be loaded");
#if DEBUG
                    _logger.Write(e.Message);
#endif
                    _projects = new List<RecentProject>();
                }
            }


            if (_projects.Count <= 0)
            {
                tsmiRecent.Visible = false;
                tsmiSepRecent.Visible = false;
                return;
            }

            tsmiRecent.DropDownItems.Clear();
            tsmiRecent.DropDownItems.AddRange(_projects.OrderByDescending(rp => rp.Accesed).ThenBy(rp => rp.Name)
                                                       .Select(CreateDropDownItem)
                                                       .ToArray());

            tsmiRecent.Visible = true;
            tsmiSepRecent.Visible = true;
        }

        private static ToolStripItem CreateDropDownItem(RecentProject arg)
        {
            return new ToolStripMenuItem($"({arg.Path})");
        }

        private void CreateImages()
        {
            foreach (var tuple in Enumerable.Range(1, 100).Select(i => new Tuple<int, Image>(i, _drawer.DrawNumber(i))))
            {
                ilTree.Images.Add($"number{tuple.Item1}", tuple.Item2);
            }
        }

        private void FillCb()
        {
            FillCbWithEnum<ContainerPolicyType>(cbContainerPolicy);
            FillCbWithEnum<AccessEnforcePolicyEnum>(cbEnforcePolicy);
            FillCbWithEnum<TransitionStates>(cbTransitionState);
            FillCbWithEnum<DisplayEnforcePolicyEnum>(cbDisplayPolicy);
            FillCbWithEnum<LearningActivityActivationState>(cbState);
            FillCbWithEnum<ProviderType>(cbProvider);
            FillCbWithEnum<ViewDisplayType>(cbMasterViewDisplay);
            FillCbWithEnum<ViewDisplayType>(cbChildViewDisplay);
            FillCbWithEnum<FrontendTheme>(cbMasterTheme);
            FillCbWithEnum<FrontendTheme>(cbChildTheme);

            cbProvider.SelectedIndex = 3;//todo change from binder

            cbOrganisations.ValueMember = nameof(OrganisationModel.Id);
            cbOrganisations.DisplayMember = nameof(OrganisationModel.Name);
        }

        private static void FillCbWithEnum<TEnum>(ComboBox comboBox)
        {
            var items = Enum.GetValues(typeof(TEnum)).OfType<TEnum>()
                               .Select(cpt => new
                               {
                                   Name = cpt.ToString(),
                                   Value = cpt
                               })
                               .Cast<object>()
                               .ToArray();

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Value";

            comboBox.Items.AddRange(items);

            comboBox.SelectedIndex = 0;
        }

        private void CreateBindings()
        {
            var binder = new UiBinder<LearningActivity>(GetSelectedLearningActivity);

            binder.Add(txtName, la => la.Name).AfterChange(SetNameToSelectedNode).Validate(new StringNotEmptyValidator(true));
            binder.Add(chkIsVisible, la => la.IsVisible).AfterChange(SetIsVisibleIconToNode);
            binder.Add(txtDisplayName, la => la.DisplayName);
            binder.Add(txtGenericInfo, la => la.GenericInfo);
            binder.Add(txtCategories, la => la.CategoriesProxy).IsThroughProxy();
            binder.Add(txtTinCanId, la => la.TinCan_Id).Validate(new UriValidator());
            binder.Add(txtLaunchUrl, la => la.TinCan_StartupFile);
            binder.Add(cbState, la => la.ActivationState);

            binder.Add(nudDisplayOrder, la => la.DisplayOrderProxy)
                  .Validate(new RangeLimiterValidator(0, 100))
                  .AfterChange(SetNumberIcon)
                  .IsThroughProxy();

            binder.Add(chkIsMandatory, la => la.IsMandatoryProxy).IsThroughProxy();
            binder.Add(cbContainerPolicy, la => la.ContainerPolicyProxy).IsThroughProxy();
            binder.Add(nudReqItems, la => la.RequiredItemsCountProxy).IsThroughProxy().Validate(new RangeLimiterValidator(0, 100));
            binder.Add(cbEnforcePolicy, la => la.AccessEnforcePolicyProxy).IsThroughProxy();
            binder.Add(cbTransitionState, la => la.TransitionStateProxy).IsThroughProxy();
            binder.Add(cbDisplayPolicy, la => la.DisplayEnforcePolicyProxy).IsThroughProxy();
            binder.Add(nudAccessOrder, la => la.AccessOrderProxy).IsThroughProxy().Validate(new RangeLimiterValidator(0, 100));
            binder.Add(txtDescription, la => la.Description);
            binder.Add(cbProvider, la => la.PackageProviderType);
            binder.Add(cbOrganisations, () => _rootOrganisationModel, model => model.OrganisationId)
                  .AfterChange(ChangedSelectedOrganisation);

            binder.Add(cbMasterViewDisplay, la => la.DisplaySettings.MasterDisplay.ViewDisplay);
            binder.Add(chkMasterShowNewFlag, la => la.DisplaySettings.MasterDisplay.ShowNewFlag);
            binder.Add(chkMasterShowProgress, la => la.DisplaySettings.MasterDisplay.ShowProgress);
            binder.Add(chkMasterShowDescription, la => la.DisplaySettings.MasterDisplay.ShowDescription);
            binder.Add(cbMasterTheme, la => la.DisplaySettings.MasterDisplay.Theme);
            binder.Add(chkMasterShowFilter, la => la.DisplaySettings.MasterDisplay.ShowFilter);
            binder.Add(chkMasterShowNavigationWidget, la => la.DisplaySettings.MasterDisplay.ShowNavigationWidget);
            binder.Add(chkMasterShowSuportWidget, la => la.DisplaySettings.MasterDisplay.ShowSupportWidget);

            binder.Add(cbChildViewDisplay, la => la.DisplaySettings.ChildDisplay.ViewDisplay);
            binder.Add(chkChildShowNewFlag, la => la.DisplaySettings.ChildDisplay.ShowNewFlag);
            binder.Add(chkChildShowProgress, la => la.DisplaySettings.ChildDisplay.ShowProgress);
            binder.Add(chkChildShowDescription, la => la.DisplaySettings.ChildDisplay.ShowDescription);
            binder.Add(chkChildShowGenericInfo, la => la.DisplaySettings.ChildDisplay.ShowGenericInfo);
            binder.Add(cbChildTheme, la => la.DisplaySettings.ChildDisplay.Theme);

            binder.BindValueChange += (sender, args) => HaveChanges = true;

            _tracker = binder;
            _binder = binder;
        }

        private void ChangedSelectedOrganisation(int organisationid)
        {
            var node = tvHierarchy.Nodes[0];
            node.Text = !string.IsNullOrEmpty(cbOrganisations.Text)
                            ? $"{cbOrganisations.Text} (root)"
                            : "(root)";

            if (node.IsSelected)
                tpGeneral.Text = node.Text;
        }

        private void SetTitle()
        {
            Text = !string.IsNullOrEmpty(FileHandledName) 
                            ? $"{BASE_TITLE} | {FileHandledName}" 
                            : BASE_TITLE;

            if (HaveChanges && !Text.EndsWith(UNSAVED_MARK))
                Text += UNSAVED_MARK;
            else if (!HaveChanges)
                Text = Text.Replace(UNSAVED_MARK, string.Empty);
        }

        private void SetNameToSelectedNode(string name)
        {
            if(tvHierarchy.SelectedNode != null)
                tvHierarchy.SelectedNode.Text = name;

            tpGeneral.Text = name;

            lblPath.Text = GetPath();
        }

        private void SetIsVisibleIconToNode(bool visible)
        {
            SetIsVisibleIconToNode(tvHierarchy.SelectedNode);
        }

        private static void SetIsVisibleIconToNode(TreeNode node)
        {
            SetTreeNodeIcon(node);
        }

        private void SetNumberIcon(int index)
        {
            SetNumberIcon(tvHierarchy.SelectedNode);
        }

        private static void SetNumberIcon(TreeNode node)
        {
            SetTreeNodeIcon(node);
        }

        private static void SetTreeNodeIcon(TreeNode node)
        {
            var la = node?.Tag as LearningActivity;

            if (la == null)
                return;

            int icon;

            if (!la.IsVisible)
                icon = (int)TreeHierarchyIcons.Ghost;
            else if (la.DisplayOrderProxy > 0)
                icon = (int)TreeHierarchyIcons.Number + la.DisplayOrderProxy - 1;
            else if (la.IsActivity)
                icon = (int)TreeHierarchyIcons.Module;
            else
                icon = (int)TreeHierarchyIcons.None;

            node.ImageIndex =
                node.SelectedImageIndex = icon;
        }

        private string GetPath()
        {
            StringBuilder sb = new StringBuilder();

            var node = tvHierarchy.SelectedNode;

            while (node.Parent != null)
            {
                var la = GetNodeLearningActivity(node);
                if(la == null)
                    break;

                sb.Insert(0, "/" + la.Name);
                node = node.Parent;
            }

            if(sb.Length == 0)
                sb.Append("/");

            return sb.ToString();
        }

        private LearningActivity GetSelectedLearningActivity() => GetNodeLearningActivity(tvHierarchy.SelectedNode);

        private static LearningActivity GetNodeLearningActivity(TreeNode node) => node?.Tag as LearningActivity;

        private void CreateLa(bool isActivity)
        {
            var selectedNode = tvHierarchy.SelectedNode;

            if (selectedNode == null)
                return;

            var selLa = selectedNode.Tag as LearningActivity;

            if (selLa != null && selLa.IsActivity)   //cannot add childs to activities
                return;

            var la = CreateLa(isActivity, selectedNode, selLa?.Id);
            var node = CreateNode(la);

            selectedNode.Nodes.Add(node);
            selectedNode.Expand();

            HaveChanges = true;

            var type = isActivity ? "Content" : "Container";

            _logger.Write($"Created {type} {la.Name}");
        }

        private static LearningActivity CreateLa(bool isActivity, TreeNode parentNode, int? parentId = null)
        {
            var type = isActivity ? "Content" : "Container";

            var name = $"{type}{parentNode.Level + 1}.{parentNode.Nodes.Count}";

            var la = new LearningActivity(isActivity, name)
            {
                //Level = parentNode.Level; // todo
                Id = ++_idCounter
            };

            if (parentId != null)
                la.ParentRelation.ParentRelationId = parentId.Value;

            return la;
        }

        private TreeNode CreateNode(LearningActivity la)
        {
            var node = new TreeNode(la.Name)
            {
                ContextMenuStrip = cmsHierarcy,
                Tag = la
            };

            SetTreeNodeIcon(node);

            return node;
        }

        private void SetFieldsEnabled()
        {
            var la = GetSelectedLearningActivity();

            if (la == null)
                return;

            txtTinCanId.Enabled =
                txtLaunchUrl.Enabled =
                nudAccessOrder.Enabled =
                cbTransitionState.Enabled =
                cbProvider.Enabled = la.IsActivity;

            cbContainerPolicy.Enabled =
                nudReqItems.Enabled =
                cbEnforcePolicy.Enabled = 
                gbMasterDisplay.Enabled = !la.IsActivity;
        }

        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show(this, "API URL cannot be empty. Please input a corrected formated endpoint url for creating an hierarchy.",
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbOrganisations.GetSelectedValue<int>() <= 0)
            {
                MessageBox.Show(this, "Organisation is not selected. Please select an organisation.",
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAuthorization.Text))
            {
                MessageBox.Show(this, "Authorization cannot be empty. Please input an Bearer authorization token.",
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show(this, "Username cannot be empty. Please input an valid username from the application.",
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tvHierarchy.Nodes[0].Nodes.Count <= 0)
            {
                MessageBox.Show(this, "No hierarchy created. You need to create a hierarchy before sending it... doah...",
                                BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string GetHierarcyJson(Formatting formatting = Formatting.None)
        {
            var hierarchy = GetHierarchy();

            _jsonSettings.Formatting = formatting;

            return JsonConvert.SerializeObject(hierarchy, _jsonSettings);
        }

        private RootActivity GetHierarchy()
        {
            var root = new RootActivity
            {
                CreateParticipants = chkCreateParts.Checked,
                CreateUserAuthorization = chkCreateUserAuth.Checked,
                ExtractProviderPackage = chkExtractProviderPack.Checked,
                TemplateUsername = txtUsername.Text,
                RootActivities = tvHierarchy.Nodes[0].Nodes.OfType<TreeNode>()
                                            .Select(CreateLearningActivityFromTreeNode)
                                            .Where(la => la != null)
                                            .ToList()
            };


            return root;
        }

        private static LearningActivity CreateLearningActivityFromTreeNode(TreeNode node)
        {
            var activity = node.Tag as LearningActivity;

            if (activity == null)
                return null;

            activity.Members = node.Nodes.OfType<TreeNode>()
                                   .Select(CreateLearningActivityFromTreeNode)
                                   .Where(la => la != null)
                                   .ToList();

            return activity;
        }

        private void ImportHierarchy(RootActivity root)
        {
            chkCreateParts.Checked = root.CreateParticipants;
            chkCreateUserAuth.Checked = root.CreateUserAuthorization;
            chkExtractProviderPack.Checked = root.ExtractProviderPackage;
            txtUsername.Text = root.TemplateUsername;

            FillHierarchy(root.RootActivities);
        }

        private void FillHierarchy(IEnumerable<LearningActivity> learningActivities)
        {
            try
            {
                tvHierarchy.BeginUpdate();
                tvHierarchy.Nodes[0].Nodes.Clear();

                AddHierarcyNodes(tvHierarchy.Nodes[0], learningActivities);

                tvHierarchy.ExpandAll();

                tvHierarchy.SelectedNode = tvHierarchy.Nodes[0];

                tvHierarchy_AfterSelect(tvHierarchy, new TreeViewEventArgs(tvHierarchy.SelectedNode, TreeViewAction.Unknown));
            }
            finally
            {
                tvHierarchy.EndUpdate();
            }
        }

        private void AddHierarcyNodes(TreeNode node, IEnumerable<LearningActivity> learningActivities)
        {
            if (learningActivities == null)
                return;

            foreach (var activity in learningActivities)
            {
                var child = CreateNode(activity);
                AddHierarcyNodes(child, activity.Members);

                node.Nodes.Add(child);
            }
        }

        private void WriteLog(string log)
        {
            txtLog.WriteLine(log);
            SetLastAcction();
        }

        private void SetLastAcction()
        {
            tssiData.Text = _logger.LastLogMessage;

            if(tmrShowLastAction.Enabled)
                tmrShowLastAction.Stop();

            tmrShowLastAction.Start();
        }

        private bool SaveHierarchy()
        {
            if (string.IsNullOrEmpty(_fileHandled))
            {
                var response = sfdSave.ShowDialog(this);

                if (response != DialogResult.OK)
                    return false;

                _fileHandled = sfdSave.FileName;
            }

            File.WriteAllText(_fileHandled, GetHierarcyJson());
            HaveChanges = false;

            _logger.Write("File saved");

            var index = _projects.FindIndex(rp => rp.Path == _fileHandled);
            if (index >= 0)
            {
                _projects.Move(index, 0);
                _projects[index].Accesed = DateTime.Now;
            }
            else
            {
                _projects.Insert(0, new RecentProject(_fileHandled));
            }

            _projects = new List<RecentProject>(_projects.Take(10));

            Settings.Default.RecentProjects = JsonConvert.SerializeObject(_projects);
            LoadRecentProjects();

            return true;
        }

        private void DeleteSelectedLearningActivity(bool showQuestion)
        {
            var la = GetSelectedLearningActivity();
            if (la == null)
                return;
            
            if (showQuestion)
            {
                var resoponse = MessageBox.Show(this,
                                                $"Are you sure you want to remove {la.Name}?",
                                                BASE_TITLE,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (resoponse != DialogResult.Yes)
                    return;
            }

            var type = la.IsActivity ? "Content" : "Container";

            _logger.Write($"Deleted {type} {tvHierarchy.SelectedNode?.Text}");
            tvHierarchy.SelectedNode?.Remove();

            HaveChanges = true;
        }

        private async Task SendHierarchy()
        {
            if (!CheckFields())
                return;

            _logger.Write("Generating Hierarhy");

            var json = GetHierarcyJson();

            try
            {
                Enabled = false;

                tsProgress.Visible = true;

                _logger.Write("Sending Hierarhy");

                var organisationId = cbOrganisations.GetSelectedValue<int>();

                if(organisationId <= 0)
                    throw new Exception("Incorect selection for organisation");

                var hierarchyService = new HierarchySenderService(txtUrl.Text);
                await hierarchyService.SendHierarchy(json, organisationId, txtAuthorization.Text);
                _logger.Write("Hierarcy sended");
            }
            catch (ServiceException ex)
            {
                _logger.Write(ex.Message);
                MessageBox.Show(this, ex.Message, BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Write("Fail to send hierarchy");
#if DEBUG
                _logger.Write("Fail to send hierarchy");
                MessageBox.Show(this, ex.Message, BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(this, "Fail to send hierarchy", BASE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            finally
            {
                Enabled = true;
                tsProgress.Visible = false;
            }
        }

        private void ShowJsonForm()
        {
            var json = GetHierarcyJson(Formatting.Indented);

            using (var jsonFormViewer = new JsonViewerForm(json))
            {
                jsonFormViewer.ShowDialog(this);
            }
        }

        #endregion
    }
}
