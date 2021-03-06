﻿namespace Jedi.HierarchyBuilder
{
    sealed partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("(root)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmsHierarcy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMoveIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tvHierarchy = new System.Windows.Forms.TreeView();
            this.ilTree = new System.Windows.Forms.ImageList(this.components);
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtGenericInfo = new System.Windows.Forms.TextBox();
            this.lblGenericInfo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategoriesInfo = new System.Windows.Forms.Label();
            this.txtLaunchUrl = new System.Windows.Forms.TextBox();
            this.lblLaunchUrl = new System.Windows.Forms.Label();
            this.txtTinCanId = new System.Windows.Forms.TextBox();
            this.lblTinCanId = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.chkIsVisible = new System.Windows.Forms.CheckBox();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tpProvider = new System.Windows.Forms.TabPage();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.tpDisplaySettings = new System.Windows.Forms.TabPage();
            this.gbMasterDisplay = new System.Windows.Forms.GroupBox();
            this.chkMasterShowSuportWidget = new System.Windows.Forms.CheckBox();
            this.chkMasterShowNavigationWidget = new System.Windows.Forms.CheckBox();
            this.chkMasterShowFilter = new System.Windows.Forms.CheckBox();
            this.cbMasterTheme = new System.Windows.Forms.ComboBox();
            this.lblMasterTheme = new System.Windows.Forms.Label();
            this.chkMasterShowGenericInfo = new System.Windows.Forms.CheckBox();
            this.chkMasterShowDescription = new System.Windows.Forms.CheckBox();
            this.chkMasterShowProgress = new System.Windows.Forms.CheckBox();
            this.chkMasterShowNewFlag = new System.Windows.Forms.CheckBox();
            this.cbMasterViewDisplay = new System.Windows.Forms.ComboBox();
            this.lblMasterViewDisplay = new System.Windows.Forms.Label();
            this.gbChildViewSettings = new System.Windows.Forms.GroupBox();
            this.cbChildTheme = new System.Windows.Forms.ComboBox();
            this.lblChildTheme = new System.Windows.Forms.Label();
            this.chkChildShowGenericInfo = new System.Windows.Forms.CheckBox();
            this.chkChildShowDescription = new System.Windows.Forms.CheckBox();
            this.chkChildShowProgress = new System.Windows.Forms.CheckBox();
            this.chkChildShowNewFlag = new System.Windows.Forms.CheckBox();
            this.cbChildViewDisplay = new System.Windows.Forms.ComboBox();
            this.lblChildViewDisplay = new System.Windows.Forms.Label();
            this.tpPolicy = new System.Windows.Forms.TabPage();
            this.nudAccessOrder = new System.Windows.Forms.NumericUpDown();
            this.lblAccessOrder = new System.Windows.Forms.Label();
            this.cbTransitionState = new System.Windows.Forms.ComboBox();
            this.lblTransitionState = new System.Windows.Forms.Label();
            this.cbDisplayPolicy = new System.Windows.Forms.ComboBox();
            this.lblDisplayPolicy = new System.Windows.Forms.Label();
            this.cbEnforcePolicy = new System.Windows.Forms.ComboBox();
            this.lblAccessEnforcePolicy = new System.Windows.Forms.Label();
            this.nudReqItems = new System.Windows.Forms.NumericUpDown();
            this.lblReqItems = new System.Windows.Forms.Label();
            this.cbContainerPolicy = new System.Windows.Forms.ComboBox();
            this.chkIsMandatory = new System.Windows.Forms.CheckBox();
            this.lblContainerPolicy = new System.Windows.Forms.Label();
            this.nudDisplayOrder = new System.Windows.Forms.NumericUpDown();
            this.lblDisplayOrder = new System.Windows.Forms.Label();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.btnOrgRefresh = new System.Windows.Forms.Button();
            this.cbOrganisations = new System.Windows.Forms.ComboBox();
            this.btnApiUrl = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.chkExtractProviderPack = new System.Windows.Forms.CheckBox();
            this.chkCreateUserAuth = new System.Windows.Forms.CheckBox();
            this.chkCreateParts = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtAuthorization = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.lblOrganisation = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSepRecent = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHierarcy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHierarcyAddContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHierarcyAddContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHierarcyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHierarcySend = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHierarchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssiData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrShowLastAction = new System.Windows.Forms.Timer(this.components);
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.tsHierarchyMove = new System.Windows.Forms.ToolStrip();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveOut = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsHierarcy.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpProvider.SuspendLayout();
            this.tpDisplaySettings.SuspendLayout();
            this.gbMasterDisplay.SuspendLayout();
            this.gbChildViewSettings.SuspendLayout();
            this.tpPolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccessOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReqItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayOrder)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.tsHierarchyMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(260, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(260, 6);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            // 
            // cmsHierarcy
            // 
            this.cmsHierarcy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsHierarcy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddContainer,
            this.tsmiAddContent,
            this.tsmiMove,
            toolStripSeparator1,
            this.tsmiDelete});
            this.cmsHierarcy.Name = "cmsHierarcy";
            this.cmsHierarcy.ShowImageMargin = false;
            this.cmsHierarcy.Size = new System.Drawing.Size(153, 114);
            this.cmsHierarcy.Opening += new System.ComponentModel.CancelEventHandler(this.cmsHierarcy_Opening);
            // 
            // tsmiAddContainer
            // 
            this.tsmiAddContainer.Name = "tsmiAddContainer";
            this.tsmiAddContainer.Size = new System.Drawing.Size(152, 26);
            this.tsmiAddContainer.Text = "Add container";
            this.tsmiAddContainer.Click += new System.EventHandler(this.tsmiAddContainer_Click);
            // 
            // tsmiAddContent
            // 
            this.tsmiAddContent.Name = "tsmiAddContent";
            this.tsmiAddContent.Size = new System.Drawing.Size(152, 26);
            this.tsmiAddContent.Text = "Add content";
            this.tsmiAddContent.Click += new System.EventHandler(this.tsmiAddContent_Click);
            // 
            // tsmiMove
            // 
            this.tsmiMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveUp,
            this.tsmiMoveDown,
            this.toolStripSeparator6,
            this.tsmiMoveIn,
            this.tsmiMoveOut});
            this.tsmiMove.Name = "tsmiMove";
            this.tsmiMove.Size = new System.Drawing.Size(152, 26);
            this.tsmiMove.Text = "Move";
            // 
            // tsmiMoveUp
            // 
            this.tsmiMoveUp.Image = global::Jedi.HierarchyBuilder.Properties.Resources.up_arrow;
            this.tsmiMoveUp.Name = "tsmiMoveUp";
            this.tsmiMoveUp.Size = new System.Drawing.Size(162, 26);
            this.tsmiMoveUp.Text = "Move up";
            this.tsmiMoveUp.Click += new System.EventHandler(this.tsmiMoveUp_Click);
            // 
            // tsmiMoveDown
            // 
            this.tsmiMoveDown.Image = global::Jedi.HierarchyBuilder.Properties.Resources.down_arrow;
            this.tsmiMoveDown.Name = "tsmiMoveDown";
            this.tsmiMoveDown.Size = new System.Drawing.Size(162, 26);
            this.tsmiMoveDown.Text = "Move down";
            this.tsmiMoveDown.Click += new System.EventHandler(this.tsmiMoveDown_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmiMoveIn
            // 
            this.tsmiMoveIn.Image = global::Jedi.HierarchyBuilder.Properties.Resources.right_arrow;
            this.tsmiMoveIn.Name = "tsmiMoveIn";
            this.tsmiMoveIn.Size = new System.Drawing.Size(162, 26);
            this.tsmiMoveIn.Text = "Move in";
            this.tsmiMoveIn.Click += new System.EventHandler(this.tsmiMoveIn_Click);
            // 
            // tsmiMoveOut
            // 
            this.tsmiMoveOut.Image = global::Jedi.HierarchyBuilder.Properties.Resources.left_arrow;
            this.tsmiMoveOut.Name = "tsmiMoveOut";
            this.tsmiMoveOut.Size = new System.Drawing.Size(162, 26);
            this.tsmiMoveOut.Text = "Move out";
            this.tsmiMoveOut.Click += new System.EventHandler(this.tsmiMoveOut_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 26);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tvHierarchy
            // 
            this.tvHierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvHierarchy.FullRowSelect = true;
            this.tvHierarchy.HideSelection = false;
            this.tvHierarchy.ImageIndex = 0;
            this.tvHierarchy.ImageList = this.ilTree;
            this.tvHierarchy.Location = new System.Drawing.Point(0, 0);
            this.tvHierarchy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvHierarchy.Name = "tvHierarchy";
            treeNode1.ContextMenuStrip = this.cmsHierarcy;
            treeNode1.ImageKey = "blank.png";
            treeNode1.Name = "nodeRoot";
            treeNode1.Text = "(root)";
            this.tvHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvHierarchy.SelectedImageIndex = 0;
            this.tvHierarchy.Size = new System.Drawing.Size(267, 485);
            this.tvHierarchy.TabIndex = 0;
            this.tvHierarchy.TabStop = false;
            this.tvHierarchy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHierarchy_AfterSelect);
            this.tvHierarchy.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvHierarchy_NodeMouseClick);
            // 
            // ilTree
            // 
            this.ilTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTree.ImageStream")));
            this.ilTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTree.Images.SetKeyName(0, "blank.png");
            this.ilTree.Images.SetKeyName(1, "ghost.png");
            this.ilTree.Images.SetKeyName(2, "module");
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpProvider);
            this.tcMain.Controls.Add(this.tpDisplaySettings);
            this.tcMain.Controls.Add(this.tpPolicy);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(559, 510);
            this.tcMain.TabIndex = 2;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.cbState);
            this.tpGeneral.Controls.Add(this.lblState);
            this.tpGeneral.Controls.Add(this.txtGenericInfo);
            this.tpGeneral.Controls.Add(this.lblGenericInfo);
            this.tpGeneral.Controls.Add(this.txtDescription);
            this.tpGeneral.Controls.Add(this.lblDescription);
            this.tpGeneral.Controls.Add(this.lblCategoriesInfo);
            this.tpGeneral.Controls.Add(this.txtLaunchUrl);
            this.tpGeneral.Controls.Add(this.lblLaunchUrl);
            this.tpGeneral.Controls.Add(this.txtTinCanId);
            this.tpGeneral.Controls.Add(this.lblTinCanId);
            this.tpGeneral.Controls.Add(this.txtDisplayName);
            this.tpGeneral.Controls.Add(this.lblDisplayName);
            this.tpGeneral.Controls.Add(this.chkIsVisible);
            this.tpGeneral.Controls.Add(this.txtCategories);
            this.tpGeneral.Controls.Add(this.lblCategories);
            this.tpGeneral.Controls.Add(this.txtName);
            this.tpGeneral.Controls.Add(this.lblName);
            this.tpGeneral.Location = new System.Drawing.Point(4, 30);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(520, 476);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // cbState
            // 
            this.cbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(356, 178);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(158, 29);
            this.cbState.TabIndex = 34;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(293, 182);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 21);
            this.lblState.TabIndex = 33;
            this.lblState.Text = "State";
            // 
            // txtGenericInfo
            // 
            this.txtGenericInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenericInfo.Location = new System.Drawing.Point(116, 178);
            this.txtGenericInfo.Name = "txtGenericInfo";
            this.txtGenericInfo.Size = new System.Drawing.Size(171, 29);
            this.txtGenericInfo.TabIndex = 6;
            // 
            // lblGenericInfo
            // 
            this.lblGenericInfo.AutoSize = true;
            this.lblGenericInfo.Location = new System.Drawing.Point(9, 182);
            this.lblGenericInfo.Name = "lblGenericInfo";
            this.lblGenericInfo.Size = new System.Drawing.Size(94, 21);
            this.lblGenericInfo.TabIndex = 32;
            this.lblGenericInfo.Text = "Generic info";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(6, 221);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(506, 88);
            this.txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 197);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description";
            // 
            // lblCategoriesInfo
            // 
            this.lblCategoriesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoriesInfo.AutoSize = true;
            this.lblCategoriesInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesInfo.Location = new System.Drawing.Point(7, 415);
            this.lblCategoriesInfo.Name = "lblCategoriesInfo";
            this.lblCategoriesInfo.Size = new System.Drawing.Size(77, 13);
            this.lblCategoriesInfo.TabIndex = 19;
            this.lblCategoriesInfo.Text = "Separated by \';\'";
            // 
            // txtLaunchUrl
            // 
            this.txtLaunchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaunchUrl.Location = new System.Drawing.Point(116, 133);
            this.txtLaunchUrl.Name = "txtLaunchUrl";
            this.txtLaunchUrl.Size = new System.Drawing.Size(396, 29);
            this.txtLaunchUrl.TabIndex = 5;
            this.txtLaunchUrl.Text = "a001index.html";
            // 
            // lblLaunchUrl
            // 
            this.lblLaunchUrl.AutoSize = true;
            this.lblLaunchUrl.Location = new System.Drawing.Point(9, 136);
            this.lblLaunchUrl.Name = "lblLaunchUrl";
            this.lblLaunchUrl.Size = new System.Drawing.Size(85, 21);
            this.lblLaunchUrl.TabIndex = 12;
            this.lblLaunchUrl.Text = "Launch Url";
            // 
            // txtTinCanId
            // 
            this.txtTinCanId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTinCanId.Location = new System.Drawing.Point(116, 97);
            this.txtTinCanId.Name = "txtTinCanId";
            this.txtTinCanId.Size = new System.Drawing.Size(396, 29);
            this.txtTinCanId.TabIndex = 4;
            this.txtTinCanId.Text = "http://id.splintt.nl/activities/sample";
            // 
            // lblTinCanId
            // 
            this.lblTinCanId.AutoSize = true;
            this.lblTinCanId.Location = new System.Drawing.Point(9, 100);
            this.lblTinCanId.Name = "lblTinCanId";
            this.lblTinCanId.Size = new System.Drawing.Size(71, 21);
            this.lblTinCanId.TabIndex = 10;
            this.lblTinCanId.Text = "TinCanId";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayName.Location = new System.Drawing.Point(116, 46);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(396, 29);
            this.txtDisplayName.TabIndex = 3;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(9, 49);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(104, 21);
            this.lblDisplayName.TabIndex = 8;
            this.lblDisplayName.Text = "Display name";
            // 
            // chkIsVisible
            // 
            this.chkIsVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsVisible.AutoSize = true;
            this.chkIsVisible.Checked = true;
            this.chkIsVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsVisible.Location = new System.Drawing.Point(422, 13);
            this.chkIsVisible.Name = "chkIsVisible";
            this.chkIsVisible.Size = new System.Drawing.Size(90, 25);
            this.chkIsVisible.TabIndex = 2;
            this.chkIsVisible.Text = "Is Visible";
            this.chkIsVisible.UseVisualStyleBackColor = true;
            // 
            // txtCategories
            // 
            this.txtCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategories.Location = new System.Drawing.Point(6, 337);
            this.txtCategories.Multiline = true;
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategories.Size = new System.Drawing.Size(506, 75);
            this.txtCategories.TabIndex = 8;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(6, 313);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(84, 21);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(116, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // tpProvider
            // 
            this.tpProvider.Controls.Add(this.cbProvider);
            this.tpProvider.Controls.Add(this.lblProvider);
            this.tpProvider.Location = new System.Drawing.Point(4, 22);
            this.tpProvider.Name = "tpProvider";
            this.tpProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tpProvider.Size = new System.Drawing.Size(520, 484);
            this.tpProvider.TabIndex = 3;
            this.tpProvider.Text = "Provider";
            this.tpProvider.UseVisualStyleBackColor = true;
            // 
            // cbProvider
            // 
            this.cbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(148, 13);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(364, 29);
            this.cbProvider.TabIndex = 9;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(6, 16);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(69, 21);
            this.lblProvider.TabIndex = 35;
            this.lblProvider.Text = "Provider";
            // 
            // tpDisplaySettings
            // 
            this.tpDisplaySettings.Controls.Add(this.gbMasterDisplay);
            this.tpDisplaySettings.Controls.Add(this.gbChildViewSettings);
            this.tpDisplaySettings.Location = new System.Drawing.Point(4, 22);
            this.tpDisplaySettings.Name = "tpDisplaySettings";
            this.tpDisplaySettings.Size = new System.Drawing.Size(520, 484);
            this.tpDisplaySettings.TabIndex = 4;
            this.tpDisplaySettings.Text = "Display settings";
            this.tpDisplaySettings.UseVisualStyleBackColor = true;
            // 
            // gbMasterDisplay
            // 
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowSuportWidget);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowNavigationWidget);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowFilter);
            this.gbMasterDisplay.Controls.Add(this.cbMasterTheme);
            this.gbMasterDisplay.Controls.Add(this.lblMasterTheme);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowGenericInfo);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowDescription);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowProgress);
            this.gbMasterDisplay.Controls.Add(this.chkMasterShowNewFlag);
            this.gbMasterDisplay.Controls.Add(this.cbMasterViewDisplay);
            this.gbMasterDisplay.Controls.Add(this.lblMasterViewDisplay);
            this.gbMasterDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMasterDisplay.Location = new System.Drawing.Point(0, 0);
            this.gbMasterDisplay.Name = "gbMasterDisplay";
            this.gbMasterDisplay.Size = new System.Drawing.Size(520, 291);
            this.gbMasterDisplay.TabIndex = 0;
            this.gbMasterDisplay.TabStop = false;
            this.gbMasterDisplay.Text = "Master view settings";
            // 
            // chkMasterShowSuportWidget
            // 
            this.chkMasterShowSuportWidget.AutoSize = true;
            this.chkMasterShowSuportWidget.Location = new System.Drawing.Point(10, 192);
            this.chkMasterShowSuportWidget.Name = "chkMasterShowSuportWidget";
            this.chkMasterShowSuportWidget.Size = new System.Drawing.Size(168, 25);
            this.chkMasterShowSuportWidget.TabIndex = 46;
            this.chkMasterShowSuportWidget.Text = "Show suport widget";
            this.chkMasterShowSuportWidget.UseVisualStyleBackColor = true;
            // 
            // chkMasterShowNavigationWidget
            // 
            this.chkMasterShowNavigationWidget.AutoSize = true;
            this.chkMasterShowNavigationWidget.Location = new System.Drawing.Point(194, 161);
            this.chkMasterShowNavigationWidget.Name = "chkMasterShowNavigationWidget";
            this.chkMasterShowNavigationWidget.Size = new System.Drawing.Size(196, 25);
            this.chkMasterShowNavigationWidget.TabIndex = 45;
            this.chkMasterShowNavigationWidget.Text = "Show navigation widget";
            this.chkMasterShowNavigationWidget.UseVisualStyleBackColor = true;
            // 
            // chkMasterShowFilter
            // 
            this.chkMasterShowFilter.AutoSize = true;
            this.chkMasterShowFilter.Location = new System.Drawing.Point(10, 161);
            this.chkMasterShowFilter.Name = "chkMasterShowFilter";
            this.chkMasterShowFilter.Size = new System.Drawing.Size(104, 25);
            this.chkMasterShowFilter.TabIndex = 44;
            this.chkMasterShowFilter.Text = "Show filter";
            this.chkMasterShowFilter.UseVisualStyleBackColor = true;
            // 
            // cbMasterTheme
            // 
            this.cbMasterTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMasterTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMasterTheme.FormattingEnabled = true;
            this.cbMasterTheme.Location = new System.Drawing.Point(148, 124);
            this.cbMasterTheme.Name = "cbMasterTheme";
            this.cbMasterTheme.Size = new System.Drawing.Size(364, 29);
            this.cbMasterTheme.TabIndex = 42;
            // 
            // lblMasterTheme
            // 
            this.lblMasterTheme.AutoSize = true;
            this.lblMasterTheme.Location = new System.Drawing.Point(6, 127);
            this.lblMasterTheme.Name = "lblMasterTheme";
            this.lblMasterTheme.Size = new System.Drawing.Size(57, 21);
            this.lblMasterTheme.TabIndex = 43;
            this.lblMasterTheme.Text = "Theme";
            // 
            // chkMasterShowGenericInfo
            // 
            this.chkMasterShowGenericInfo.AutoSize = true;
            this.chkMasterShowGenericInfo.Location = new System.Drawing.Point(194, 93);
            this.chkMasterShowGenericInfo.Name = "chkMasterShowGenericInfo";
            this.chkMasterShowGenericInfo.Size = new System.Drawing.Size(154, 25);
            this.chkMasterShowGenericInfo.TabIndex = 41;
            this.chkMasterShowGenericInfo.Text = "Show generic info";
            this.chkMasterShowGenericInfo.UseVisualStyleBackColor = true;
            // 
            // chkMasterShowDescription
            // 
            this.chkMasterShowDescription.AutoSize = true;
            this.chkMasterShowDescription.Location = new System.Drawing.Point(10, 93);
            this.chkMasterShowDescription.Name = "chkMasterShowDescription";
            this.chkMasterShowDescription.Size = new System.Drawing.Size(149, 25);
            this.chkMasterShowDescription.TabIndex = 40;
            this.chkMasterShowDescription.Text = "Show description";
            this.chkMasterShowDescription.UseVisualStyleBackColor = true;
            // 
            // chkMasterShowProgress
            // 
            this.chkMasterShowProgress.AutoSize = true;
            this.chkMasterShowProgress.Location = new System.Drawing.Point(194, 62);
            this.chkMasterShowProgress.Name = "chkMasterShowProgress";
            this.chkMasterShowProgress.Size = new System.Drawing.Size(133, 25);
            this.chkMasterShowProgress.TabIndex = 39;
            this.chkMasterShowProgress.Text = "Show progress";
            this.chkMasterShowProgress.UseVisualStyleBackColor = true;
            // 
            // chkMasterShowNewFlag
            // 
            this.chkMasterShowNewFlag.AutoSize = true;
            this.chkMasterShowNewFlag.Location = new System.Drawing.Point(10, 62);
            this.chkMasterShowNewFlag.Name = "chkMasterShowNewFlag";
            this.chkMasterShowNewFlag.Size = new System.Drawing.Size(131, 25);
            this.chkMasterShowNewFlag.TabIndex = 38;
            this.chkMasterShowNewFlag.Text = "Show new flag";
            this.chkMasterShowNewFlag.UseVisualStyleBackColor = true;
            // 
            // cbMasterViewDisplay
            // 
            this.cbMasterViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMasterViewDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMasterViewDisplay.FormattingEnabled = true;
            this.cbMasterViewDisplay.Location = new System.Drawing.Point(148, 22);
            this.cbMasterViewDisplay.Name = "cbMasterViewDisplay";
            this.cbMasterViewDisplay.Size = new System.Drawing.Size(364, 29);
            this.cbMasterViewDisplay.TabIndex = 36;
            // 
            // lblMasterViewDisplay
            // 
            this.lblMasterViewDisplay.AutoSize = true;
            this.lblMasterViewDisplay.Location = new System.Drawing.Point(6, 25);
            this.lblMasterViewDisplay.Name = "lblMasterViewDisplay";
            this.lblMasterViewDisplay.Size = new System.Drawing.Size(99, 21);
            this.lblMasterViewDisplay.TabIndex = 37;
            this.lblMasterViewDisplay.Text = "View Display";
            // 
            // gbChildViewSettings
            // 
            this.gbChildViewSettings.Controls.Add(this.cbChildTheme);
            this.gbChildViewSettings.Controls.Add(this.lblChildTheme);
            this.gbChildViewSettings.Controls.Add(this.chkChildShowGenericInfo);
            this.gbChildViewSettings.Controls.Add(this.chkChildShowDescription);
            this.gbChildViewSettings.Controls.Add(this.chkChildShowProgress);
            this.gbChildViewSettings.Controls.Add(this.chkChildShowNewFlag);
            this.gbChildViewSettings.Controls.Add(this.cbChildViewDisplay);
            this.gbChildViewSettings.Controls.Add(this.lblChildViewDisplay);
            this.gbChildViewSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbChildViewSettings.Location = new System.Drawing.Point(0, 291);
            this.gbChildViewSettings.Name = "gbChildViewSettings";
            this.gbChildViewSettings.Size = new System.Drawing.Size(520, 193);
            this.gbChildViewSettings.TabIndex = 1;
            this.gbChildViewSettings.TabStop = false;
            this.gbChildViewSettings.Text = "Child view settings";
            // 
            // cbChildTheme
            // 
            this.cbChildTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChildTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChildTheme.FormattingEnabled = true;
            this.cbChildTheme.Location = new System.Drawing.Point(149, 146);
            this.cbChildTheme.Name = "cbChildTheme";
            this.cbChildTheme.Size = new System.Drawing.Size(364, 29);
            this.cbChildTheme.TabIndex = 50;
            // 
            // lblChildTheme
            // 
            this.lblChildTheme.AutoSize = true;
            this.lblChildTheme.Location = new System.Drawing.Point(7, 149);
            this.lblChildTheme.Name = "lblChildTheme";
            this.lblChildTheme.Size = new System.Drawing.Size(57, 21);
            this.lblChildTheme.TabIndex = 51;
            this.lblChildTheme.Text = "Theme";
            // 
            // chkChildShowGenericInfo
            // 
            this.chkChildShowGenericInfo.AutoSize = true;
            this.chkChildShowGenericInfo.Location = new System.Drawing.Point(195, 103);
            this.chkChildShowGenericInfo.Name = "chkChildShowGenericInfo";
            this.chkChildShowGenericInfo.Size = new System.Drawing.Size(154, 25);
            this.chkChildShowGenericInfo.TabIndex = 49;
            this.chkChildShowGenericInfo.Text = "Show generic info";
            this.chkChildShowGenericInfo.UseVisualStyleBackColor = true;
            // 
            // chkChildShowDescription
            // 
            this.chkChildShowDescription.AutoSize = true;
            this.chkChildShowDescription.Location = new System.Drawing.Point(11, 103);
            this.chkChildShowDescription.Name = "chkChildShowDescription";
            this.chkChildShowDescription.Size = new System.Drawing.Size(149, 25);
            this.chkChildShowDescription.TabIndex = 48;
            this.chkChildShowDescription.Text = "Show description";
            this.chkChildShowDescription.UseVisualStyleBackColor = true;
            // 
            // chkChildShowProgress
            // 
            this.chkChildShowProgress.AutoSize = true;
            this.chkChildShowProgress.Location = new System.Drawing.Point(195, 72);
            this.chkChildShowProgress.Name = "chkChildShowProgress";
            this.chkChildShowProgress.Size = new System.Drawing.Size(133, 25);
            this.chkChildShowProgress.TabIndex = 47;
            this.chkChildShowProgress.Text = "Show progress";
            this.chkChildShowProgress.UseVisualStyleBackColor = true;
            // 
            // chkChildShowNewFlag
            // 
            this.chkChildShowNewFlag.AutoSize = true;
            this.chkChildShowNewFlag.Location = new System.Drawing.Point(11, 72);
            this.chkChildShowNewFlag.Name = "chkChildShowNewFlag";
            this.chkChildShowNewFlag.Size = new System.Drawing.Size(131, 25);
            this.chkChildShowNewFlag.TabIndex = 46;
            this.chkChildShowNewFlag.Text = "Show new flag";
            this.chkChildShowNewFlag.UseVisualStyleBackColor = true;
            // 
            // cbChildViewDisplay
            // 
            this.cbChildViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChildViewDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChildViewDisplay.FormattingEnabled = true;
            this.cbChildViewDisplay.Location = new System.Drawing.Point(149, 28);
            this.cbChildViewDisplay.Name = "cbChildViewDisplay";
            this.cbChildViewDisplay.Size = new System.Drawing.Size(364, 29);
            this.cbChildViewDisplay.TabIndex = 44;
            // 
            // lblChildViewDisplay
            // 
            this.lblChildViewDisplay.AutoSize = true;
            this.lblChildViewDisplay.Location = new System.Drawing.Point(7, 31);
            this.lblChildViewDisplay.Name = "lblChildViewDisplay";
            this.lblChildViewDisplay.Size = new System.Drawing.Size(99, 21);
            this.lblChildViewDisplay.TabIndex = 45;
            this.lblChildViewDisplay.Text = "View Display";
            // 
            // tpPolicy
            // 
            this.tpPolicy.Controls.Add(this.nudAccessOrder);
            this.tpPolicy.Controls.Add(this.lblAccessOrder);
            this.tpPolicy.Controls.Add(this.cbTransitionState);
            this.tpPolicy.Controls.Add(this.lblTransitionState);
            this.tpPolicy.Controls.Add(this.cbDisplayPolicy);
            this.tpPolicy.Controls.Add(this.lblDisplayPolicy);
            this.tpPolicy.Controls.Add(this.cbEnforcePolicy);
            this.tpPolicy.Controls.Add(this.lblAccessEnforcePolicy);
            this.tpPolicy.Controls.Add(this.nudReqItems);
            this.tpPolicy.Controls.Add(this.lblReqItems);
            this.tpPolicy.Controls.Add(this.cbContainerPolicy);
            this.tpPolicy.Controls.Add(this.chkIsMandatory);
            this.tpPolicy.Controls.Add(this.lblContainerPolicy);
            this.tpPolicy.Controls.Add(this.nudDisplayOrder);
            this.tpPolicy.Controls.Add(this.lblDisplayOrder);
            this.tpPolicy.Location = new System.Drawing.Point(4, 22);
            this.tpPolicy.Name = "tpPolicy";
            this.tpPolicy.Padding = new System.Windows.Forms.Padding(3);
            this.tpPolicy.Size = new System.Drawing.Size(520, 484);
            this.tpPolicy.TabIndex = 2;
            this.tpPolicy.Text = "Policy";
            this.tpPolicy.UseVisualStyleBackColor = true;
            // 
            // nudAccessOrder
            // 
            this.nudAccessOrder.Location = new System.Drawing.Point(133, 195);
            this.nudAccessOrder.Name = "nudAccessOrder";
            this.nudAccessOrder.Size = new System.Drawing.Size(120, 29);
            this.nudAccessOrder.TabIndex = 16;
            this.nudAccessOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccessOrder
            // 
            this.lblAccessOrder.AutoSize = true;
            this.lblAccessOrder.Location = new System.Drawing.Point(7, 199);
            this.lblAccessOrder.Name = "lblAccessOrder";
            this.lblAccessOrder.Size = new System.Drawing.Size(98, 21);
            this.lblAccessOrder.TabIndex = 43;
            this.lblAccessOrder.Text = "Access order";
            // 
            // cbTransitionState
            // 
            this.cbTransitionState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransitionState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransitionState.FormattingEnabled = true;
            this.cbTransitionState.Location = new System.Drawing.Point(136, 121);
            this.cbTransitionState.Name = "cbTransitionState";
            this.cbTransitionState.Size = new System.Drawing.Size(364, 29);
            this.cbTransitionState.TabIndex = 14;
            // 
            // lblTransitionState
            // 
            this.lblTransitionState.AutoSize = true;
            this.lblTransitionState.Location = new System.Drawing.Point(7, 125);
            this.lblTransitionState.Name = "lblTransitionState";
            this.lblTransitionState.Size = new System.Drawing.Size(115, 21);
            this.lblTransitionState.TabIndex = 41;
            this.lblTransitionState.Text = "Transition state";
            // 
            // cbDisplayPolicy
            // 
            this.cbDisplayPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisplayPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplayPolicy.FormattingEnabled = true;
            this.cbDisplayPolicy.Location = new System.Drawing.Point(136, 158);
            this.cbDisplayPolicy.Name = "cbDisplayPolicy";
            this.cbDisplayPolicy.Size = new System.Drawing.Size(364, 29);
            this.cbDisplayPolicy.TabIndex = 15;
            // 
            // lblDisplayPolicy
            // 
            this.lblDisplayPolicy.AutoSize = true;
            this.lblDisplayPolicy.Location = new System.Drawing.Point(7, 162);
            this.lblDisplayPolicy.Name = "lblDisplayPolicy";
            this.lblDisplayPolicy.Size = new System.Drawing.Size(105, 21);
            this.lblDisplayPolicy.TabIndex = 39;
            this.lblDisplayPolicy.Text = "Display Policy";
            // 
            // cbEnforcePolicy
            // 
            this.cbEnforcePolicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnforcePolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnforcePolicy.FormattingEnabled = true;
            this.cbEnforcePolicy.Location = new System.Drawing.Point(136, 84);
            this.cbEnforcePolicy.Name = "cbEnforcePolicy";
            this.cbEnforcePolicy.Size = new System.Drawing.Size(364, 29);
            this.cbEnforcePolicy.TabIndex = 13;
            // 
            // lblAccessEnforcePolicy
            // 
            this.lblAccessEnforcePolicy.AutoSize = true;
            this.lblAccessEnforcePolicy.Location = new System.Drawing.Point(7, 88);
            this.lblAccessEnforcePolicy.Name = "lblAccessEnforcePolicy";
            this.lblAccessEnforcePolicy.Size = new System.Drawing.Size(100, 21);
            this.lblAccessEnforcePolicy.TabIndex = 37;
            this.lblAccessEnforcePolicy.Text = "Access Policy";
            // 
            // nudReqItems
            // 
            this.nudReqItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudReqItems.Location = new System.Drawing.Point(384, 6);
            this.nudReqItems.Name = "nudReqItems";
            this.nudReqItems.Size = new System.Drawing.Size(116, 29);
            this.nudReqItems.TabIndex = 11;
            this.nudReqItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReqItems
            // 
            this.lblReqItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReqItems.AutoSize = true;
            this.lblReqItems.Location = new System.Drawing.Point(263, 10);
            this.lblReqItems.Name = "lblReqItems";
            this.lblReqItems.Size = new System.Drawing.Size(115, 21);
            this.lblReqItems.TabIndex = 35;
            this.lblReqItems.Text = "Required Items";
            // 
            // cbContainerPolicy
            // 
            this.cbContainerPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContainerPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContainerPolicy.FormattingEnabled = true;
            this.cbContainerPolicy.Location = new System.Drawing.Point(136, 47);
            this.cbContainerPolicy.Name = "cbContainerPolicy";
            this.cbContainerPolicy.Size = new System.Drawing.Size(364, 29);
            this.cbContainerPolicy.TabIndex = 12;
            // 
            // chkIsMandatory
            // 
            this.chkIsMandatory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsMandatory.AutoSize = true;
            this.chkIsMandatory.Location = new System.Drawing.Point(384, 197);
            this.chkIsMandatory.Name = "chkIsMandatory";
            this.chkIsMandatory.Size = new System.Drawing.Size(120, 25);
            this.chkIsMandatory.TabIndex = 17;
            this.chkIsMandatory.Text = "Is Mandatory";
            this.chkIsMandatory.UseVisualStyleBackColor = true;
            // 
            // lblContainerPolicy
            // 
            this.lblContainerPolicy.AutoSize = true;
            this.lblContainerPolicy.Location = new System.Drawing.Point(7, 51);
            this.lblContainerPolicy.Name = "lblContainerPolicy";
            this.lblContainerPolicy.Size = new System.Drawing.Size(122, 21);
            this.lblContainerPolicy.TabIndex = 32;
            this.lblContainerPolicy.Text = "Container Policy";
            // 
            // nudDisplayOrder
            // 
            this.nudDisplayOrder.Location = new System.Drawing.Point(136, 6);
            this.nudDisplayOrder.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudDisplayOrder.Name = "nudDisplayOrder";
            this.nudDisplayOrder.Size = new System.Drawing.Size(120, 29);
            this.nudDisplayOrder.TabIndex = 10;
            this.nudDisplayOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDisplayOrder
            // 
            this.lblDisplayOrder.AutoSize = true;
            this.lblDisplayOrder.Location = new System.Drawing.Point(7, 14);
            this.lblDisplayOrder.Name = "lblDisplayOrder";
            this.lblDisplayOrder.Size = new System.Drawing.Size(103, 21);
            this.lblDisplayOrder.TabIndex = 30;
            this.lblDisplayOrder.Text = "Display order";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.btnOrgRefresh);
            this.tpSettings.Controls.Add(this.cbOrganisations);
            this.tpSettings.Controls.Add(this.btnApiUrl);
            this.tpSettings.Controls.Add(this.btnJson);
            this.tpSettings.Controls.Add(this.chkExtractProviderPack);
            this.tpSettings.Controls.Add(this.chkCreateUserAuth);
            this.tpSettings.Controls.Add(this.chkCreateParts);
            this.tpSettings.Controls.Add(this.btnSend);
            this.tpSettings.Controls.Add(this.txtUrl);
            this.tpSettings.Controls.Add(this.lblUrl);
            this.tpSettings.Controls.Add(this.txtUsername);
            this.tpSettings.Controls.Add(this.lblUserName);
            this.tpSettings.Controls.Add(this.txtAuthorization);
            this.tpSettings.Controls.Add(this.lblAuth);
            this.tpSettings.Controls.Add(this.lblOrganisation);
            this.tpSettings.Controls.Add(this.gbLog);
            this.tpSettings.Location = new System.Drawing.Point(4, 30);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(551, 476);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnOrgRefresh
            // 
            this.btnOrgRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgRefresh.Location = new System.Drawing.Point(467, 51);
            this.btnOrgRefresh.Name = "btnOrgRefresh";
            this.btnOrgRefresh.Size = new System.Drawing.Size(71, 30);
            this.btnOrgRefresh.TabIndex = 21;
            this.btnOrgRefresh.Text = "Refresh";
            this.ttInfo.SetToolTip(this.btnOrgRefresh, "Create dummy organisation for testing");
            this.btnOrgRefresh.UseVisualStyleBackColor = true;
            this.btnOrgRefresh.Click += new System.EventHandler(this.btnOrgRefresh_Click);
            // 
            // cbOrganisations
            // 
            this.cbOrganisations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrganisations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrganisations.FormattingEnabled = true;
            this.cbOrganisations.Location = new System.Drawing.Point(163, 51);
            this.cbOrganisations.Name = "cbOrganisations";
            this.cbOrganisations.Size = new System.Drawing.Size(298, 29);
            this.cbOrganisations.TabIndex = 20;
            // 
            // btnApiUrl
            // 
            this.btnApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApiUrl.Location = new System.Drawing.Point(467, 9);
            this.btnApiUrl.Name = "btnApiUrl";
            this.btnApiUrl.Size = new System.Drawing.Size(71, 30);
            this.btnApiUrl.TabIndex = 19;
            this.btnApiUrl.Text = "Save";
            this.ttInfo.SetToolTip(this.btnApiUrl, "Create dummy organisation for testing");
            this.btnApiUrl.UseVisualStyleBackColor = true;
            this.btnApiUrl.Click += new System.EventHandler(this.btnApiUrl_Click);
            // 
            // btnJson
            // 
            this.btnJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJson.Location = new System.Drawing.Point(407, 238);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(131, 44);
            this.btnJson.TabIndex = 27;
            this.btnJson.Text = "Generate JSON";
            this.ttInfo.SetToolTip(this.btnJson, "Preview hierachy asociated JSON");
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // chkExtractProviderPack
            // 
            this.chkExtractProviderPack.AutoSize = true;
            this.chkExtractProviderPack.Checked = true;
            this.chkExtractProviderPack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExtractProviderPack.Location = new System.Drawing.Point(16, 310);
            this.chkExtractProviderPack.Name = "chkExtractProviderPack";
            this.chkExtractProviderPack.Size = new System.Drawing.Size(199, 25);
            this.chkExtractProviderPack.TabIndex = 26;
            this.chkExtractProviderPack.Text = "Extract provider package";
            this.chkExtractProviderPack.UseVisualStyleBackColor = true;
            // 
            // chkCreateUserAuth
            // 
            this.chkCreateUserAuth.AutoSize = true;
            this.chkCreateUserAuth.Checked = true;
            this.chkCreateUserAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateUserAuth.Location = new System.Drawing.Point(227, 279);
            this.chkCreateUserAuth.Name = "chkCreateUserAuth";
            this.chkCreateUserAuth.Size = new System.Drawing.Size(170, 25);
            this.chkCreateUserAuth.TabIndex = 25;
            this.chkCreateUserAuth.Text = "Create authorisation";
            this.chkCreateUserAuth.UseVisualStyleBackColor = true;
            // 
            // chkCreateParts
            // 
            this.chkCreateParts.AutoSize = true;
            this.chkCreateParts.Checked = true;
            this.chkCreateParts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateParts.Location = new System.Drawing.Point(16, 279);
            this.chkCreateParts.Name = "chkCreateParts";
            this.chkCreateParts.Size = new System.Drawing.Size(159, 25);
            this.chkCreateParts.TabIndex = 24;
            this.chkCreateParts.Text = "Create participants";
            this.chkCreateParts.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(407, 289);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 44);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "Send";
            this.ttInfo.SetToolTip(this.btnSend, "Send the hierarchy to the API");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(163, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(298, 29);
            this.txtUrl.TabIndex = 18;
            this.txtUrl.Text = "https://jedi-api-main-dev.splintt.nl\r\n";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(66, 21);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "API URL";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 239);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 29);
            this.txtUsername.TabIndex = 23;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 243);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 21);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Template username";
            // 
            // txtAuthorization
            // 
            this.txtAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorization.Location = new System.Drawing.Point(16, 120);
            this.txtAuthorization.Multiline = true;
            this.txtAuthorization.Name = "txtAuthorization";
            this.txtAuthorization.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuthorization.Size = new System.Drawing.Size(522, 107);
            this.txtAuthorization.TabIndex = 22;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(12, 95);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(104, 21);
            this.lblAuth.TabIndex = 3;
            this.lblAuth.Text = "Authorization";
            // 
            // lblOrganisation
            // 
            this.lblOrganisation.AutoSize = true;
            this.lblOrganisation.Location = new System.Drawing.Point(12, 54);
            this.lblOrganisation.Name = "lblOrganisation";
            this.lblOrganisation.Size = new System.Drawing.Size(100, 21);
            this.lblOrganisation.TabIndex = 1;
            this.lblOrganisation.Text = "Organisation";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbLog.Location = new System.Drawing.Point(3, 332);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(545, 141);
            this.gbLog.TabIndex = 0;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 25);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(539, 113);
            this.txtLog.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiHierarcy,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(834, 29);
            this.msMain.TabIndex = 3;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileNew,
            this.tsmiFileSave,
            this.tsmiFileImport,
            this.tsmiSepRecent,
            this.tsmiRecent,
            toolStripSeparator2,
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(50, 25);
            this.tsmiFile.Text = "FILE";
            // 
            // tsmiFileNew
            // 
            this.tsmiFileNew.Name = "tsmiFileNew";
            this.tsmiFileNew.Size = new System.Drawing.Size(185, 26);
            this.tsmiFileNew.Text = "New hierarchy";
            this.tsmiFileNew.Click += new System.EventHandler(this.tsmiFileNew_Click);
            // 
            // tsmiFileSave
            // 
            this.tsmiFileSave.Name = "tsmiFileSave";
            this.tsmiFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiFileSave.Size = new System.Drawing.Size(185, 26);
            this.tsmiFileSave.Text = "Save";
            this.tsmiFileSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsmiFileImport
            // 
            this.tsmiFileImport.Name = "tsmiFileImport";
            this.tsmiFileImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFileImport.Size = new System.Drawing.Size(185, 26);
            this.tsmiFileImport.Text = "Import";
            this.tsmiFileImport.Click += new System.EventHandler(this.tsmiFileImport_Click);
            // 
            // tsmiSepRecent
            // 
            this.tsmiSepRecent.Name = "tsmiSepRecent";
            this.tsmiSepRecent.Size = new System.Drawing.Size(182, 6);
            // 
            // tsmiRecent
            // 
            this.tsmiRecent.Name = "tsmiRecent";
            this.tsmiRecent.Size = new System.Drawing.Size(185, 26);
            this.tsmiRecent.Text = "Recent Files";
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiFileExit.Size = new System.Drawing.Size(185, 26);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditUndo,
            this.tsmiEditRedo});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(53, 25);
            this.tsmiEdit.Text = "EDIT";
            this.tsmiEdit.Visible = false;
            // 
            // tsmiEditUndo
            // 
            this.tsmiEditUndo.Name = "tsmiEditUndo";
            this.tsmiEditUndo.Size = new System.Drawing.Size(126, 26);
            this.tsmiEditUndo.Text = "UNDO";
            this.tsmiEditUndo.Click += new System.EventHandler(this.tsmiEditUndo_Click);
            // 
            // tsmiEditRedo
            // 
            this.tsmiEditRedo.Name = "tsmiEditRedo";
            this.tsmiEditRedo.Size = new System.Drawing.Size(126, 26);
            this.tsmiEditRedo.Text = "REDO";
            this.tsmiEditRedo.Click += new System.EventHandler(this.tsmiEditRedo_Click);
            // 
            // tsmiHierarcy
            // 
            this.tsmiHierarcy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHierarcyAddContent,
            this.tsmiHierarcyAddContainer,
            toolStripSeparator3,
            this.tsmiHierarcyDelete,
            toolStripSeparator4,
            this.tsmiHierarcySend,
            this.viewHierarchyToolStripMenuItem});
            this.tsmiHierarcy.Name = "tsmiHierarcy";
            this.tsmiHierarcy.Size = new System.Drawing.Size(105, 25);
            this.tsmiHierarcy.Text = "HIERARCHY";
            // 
            // tsmiHierarcyAddContent
            // 
            this.tsmiHierarcyAddContent.Name = "tsmiHierarcyAddContent";
            this.tsmiHierarcyAddContent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiHierarcyAddContent.Size = new System.Drawing.Size(263, 26);
            this.tsmiHierarcyAddContent.Text = "Add content";
            this.tsmiHierarcyAddContent.Click += new System.EventHandler(this.tsmiHierarcyAddContent_Click);
            // 
            // tsmiHierarcyAddContainer
            // 
            this.tsmiHierarcyAddContainer.Name = "tsmiHierarcyAddContainer";
            this.tsmiHierarcyAddContainer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiHierarcyAddContainer.Size = new System.Drawing.Size(263, 26);
            this.tsmiHierarcyAddContainer.Text = "Add container";
            this.tsmiHierarcyAddContainer.Click += new System.EventHandler(this.tsmiHierarcyAddContainer_Click);
            // 
            // tsmiHierarcyDelete
            // 
            this.tsmiHierarcyDelete.Name = "tsmiHierarcyDelete";
            this.tsmiHierarcyDelete.Size = new System.Drawing.Size(263, 26);
            this.tsmiHierarcyDelete.Text = "Delete selected item";
            this.tsmiHierarcyDelete.Click += new System.EventHandler(this.tsmiHierarcyDelete_Click);
            // 
            // tsmiHierarcySend
            // 
            this.tsmiHierarcySend.Name = "tsmiHierarcySend";
            this.tsmiHierarcySend.Size = new System.Drawing.Size(263, 26);
            this.tsmiHierarcySend.Text = "Send hierarchy";
            this.tsmiHierarcySend.Click += new System.EventHandler(this.tsmiHierarcySend_Click);
            // 
            // viewHierarchyToolStripMenuItem
            // 
            this.viewHierarchyToolStripMenuItem.Name = "viewHierarchyToolStripMenuItem";
            this.viewHierarchyToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.viewHierarchyToolStripMenuItem.Text = "View hierarchy";
            this.viewHierarchyToolStripMenuItem.Click += new System.EventHandler(this.viewHierarchyToolStripMenuItem_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpHelp,
            toolStripSeparator5,
            this.tsmiHelpAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(58, 25);
            this.tsmiHelp.Text = "HELP";
            // 
            // tsmiHelpHelp
            // 
            this.tsmiHelpHelp.Name = "tsmiHelpHelp";
            this.tsmiHelpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiHelpHelp.Size = new System.Drawing.Size(139, 26);
            this.tsmiHelpHelp.Text = "Help";
            this.tsmiHelpHelp.Click += new System.EventHandler(this.tsmiHelpHelp_Click);
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(139, 26);
            this.tsmiHelpAbout.Text = "About";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.tsmiHelpAbout_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.Filter = "Jedi Hirerachy Files|*.jh";
            // 
            // ofdImport
            // 
            this.ofdImport.Filter = "Jedi Hierarchy Files|*.jh|All files|*.*";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssiData,
            this.tsProgress,
            this.lblPath});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(834, 22);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssiData
            // 
            this.tssiData.AutoSize = false;
            this.tssiData.Name = "tssiData";
            this.tssiData.Size = new System.Drawing.Size(200, 17);
            this.tssiData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsProgress
            // 
            this.tsProgress.MarqueeAnimationSpeed = 20;
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            this.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tsProgress.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(12, 17);
            this.lblPath.Text = "/";
            // 
            // tmrShowLastAction
            // 
            this.tmrShowLastAction.Interval = 1000;
            this.tmrShowLastAction.Tick += new System.EventHandler(this.tmrShowLastAction_Tick);
            // 
            // spContainer
            // 
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 29);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.tvHierarchy);
            this.spContainer.Panel1.Controls.Add(this.tsHierarchyMove);
            this.spContainer.Panel1MinSize = 250;
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.tcMain);
            this.spContainer.Panel2MinSize = 520;
            this.spContainer.Size = new System.Drawing.Size(834, 510);
            this.spContainer.SplitterDistance = 267;
            this.spContainer.SplitterWidth = 8;
            this.spContainer.TabIndex = 5;
            // 
            // tsHierarchyMove
            // 
            this.tsHierarchyMove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsHierarchyMove.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsHierarchyMove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.tsbMoveOut,
            this.tsbMoveIn,
            this.toolStripSeparator7,
            this.tsbDelete});
            this.tsHierarchyMove.Location = new System.Drawing.Point(0, 485);
            this.tsHierarchyMove.Name = "tsHierarchyMove";
            this.tsHierarchyMove.Size = new System.Drawing.Size(267, 25);
            this.tsHierarchyMove.TabIndex = 1;
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveUp.Image = global::Jedi.HierarchyBuilder.Properties.Resources.up_arrow;
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveUp.Text = "MoveUp";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsmiMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveDown.Image = global::Jedi.HierarchyBuilder.Properties.Resources.down_arrow;
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveDown.Text = "MoveDown";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsmiMoveDown_Click);
            // 
            // tsbMoveOut
            // 
            this.tsbMoveOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveOut.Image = global::Jedi.HierarchyBuilder.Properties.Resources.left_arrow;
            this.tsbMoveOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveOut.Name = "tsbMoveOut";
            this.tsbMoveOut.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveOut.Text = "MoveIOut";
            this.tsbMoveOut.Click += new System.EventHandler(this.tsmiMoveOut_Click);
            // 
            // tsbMoveIn
            // 
            this.tsbMoveIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveIn.Image = global::Jedi.HierarchyBuilder.Properties.Resources.right_arrow;
            this.tsbMoveIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveIn.Name = "tsbMoveIn";
            this.tsbMoveIn.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveIn.Text = "MoveIn";
            this.tsbMoveIn.Click += new System.EventHandler(this.tsmiMoveIn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Jedi.HierarchyBuilder.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jedi - Hierearcy Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsHierarcy.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpProvider.ResumeLayout(false);
            this.tpProvider.PerformLayout();
            this.tpDisplaySettings.ResumeLayout(false);
            this.gbMasterDisplay.ResumeLayout(false);
            this.gbMasterDisplay.PerformLayout();
            this.gbChildViewSettings.ResumeLayout(false);
            this.gbChildViewSettings.PerformLayout();
            this.tpPolicy.ResumeLayout(false);
            this.tpPolicy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccessOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReqItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayOrder)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel1.PerformLayout();
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.tsHierarchyMove.ResumeLayout(false);
            this.tsHierarchyMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHierarchy;
        private System.Windows.Forms.ContextMenuStrip cmsHierarcy;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddContent;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblOrganisation;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.CheckBox chkIsVisible;
        private System.Windows.Forms.ImageList ilTree;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtTinCanId;
        private System.Windows.Forms.Label lblTinCanId;
        private System.Windows.Forms.TextBox txtLaunchUrl;
        private System.Windows.Forms.Label lblLaunchUrl;
        private System.Windows.Forms.Label lblCategoriesInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtGenericInfo;
        private System.Windows.Forms.Label lblGenericInfo;
        private System.Windows.Forms.TabPage tpPolicy;
        private System.Windows.Forms.NumericUpDown nudAccessOrder;
        private System.Windows.Forms.Label lblAccessOrder;
        private System.Windows.Forms.ComboBox cbTransitionState;
        private System.Windows.Forms.Label lblTransitionState;
        private System.Windows.Forms.ComboBox cbDisplayPolicy;
        private System.Windows.Forms.Label lblDisplayPolicy;
        private System.Windows.Forms.ComboBox cbEnforcePolicy;
        private System.Windows.Forms.Label lblAccessEnforcePolicy;
        private System.Windows.Forms.NumericUpDown nudReqItems;
        private System.Windows.Forms.Label lblReqItems;
        private System.Windows.Forms.ComboBox cbContainerPolicy;
        private System.Windows.Forms.CheckBox chkIsMandatory;
        private System.Windows.Forms.Label lblContainerPolicy;
        private System.Windows.Forms.NumericUpDown nudDisplayOrder;
        private System.Windows.Forms.Label lblDisplayOrder;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHierarcy;
        private System.Windows.Forms.ToolStripMenuItem tsmiHierarcyAddContent;
        private System.Windows.Forms.ToolStripMenuItem tsmiHierarcyAddContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiHierarcyDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiHierarcySend;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditRedo;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.CheckBox chkExtractProviderPack;
        private System.Windows.Forms.CheckBox chkCreateUserAuth;
        private System.Windows.Forms.CheckBox chkCreateParts;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssiData;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.Timer tmrShowLastAction;
        private System.Windows.Forms.TextBox txtAuthorization;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.ToolStripMenuItem viewHierarchyToolStripMenuItem;
        private System.Windows.Forms.TabPage tpProvider;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button btnApiUrl;
        private System.Windows.Forms.ComboBox cbOrganisations;
        private System.Windows.Forms.Button btnOrgRefresh;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.TabPage tpDisplaySettings;
        private System.Windows.Forms.GroupBox gbMasterDisplay;
        private System.Windows.Forms.GroupBox gbChildViewSettings;
        private System.Windows.Forms.CheckBox chkMasterShowSuportWidget;
        private System.Windows.Forms.CheckBox chkMasterShowNavigationWidget;
        private System.Windows.Forms.CheckBox chkMasterShowFilter;
        private System.Windows.Forms.ComboBox cbMasterTheme;
        private System.Windows.Forms.Label lblMasterTheme;
        private System.Windows.Forms.CheckBox chkMasterShowGenericInfo;
        private System.Windows.Forms.CheckBox chkMasterShowDescription;
        private System.Windows.Forms.CheckBox chkMasterShowProgress;
        private System.Windows.Forms.CheckBox chkMasterShowNewFlag;
        private System.Windows.Forms.ComboBox cbMasterViewDisplay;
        private System.Windows.Forms.Label lblMasterViewDisplay;
        private System.Windows.Forms.ComboBox cbChildTheme;
        private System.Windows.Forms.Label lblChildTheme;
        private System.Windows.Forms.CheckBox chkChildShowGenericInfo;
        private System.Windows.Forms.CheckBox chkChildShowDescription;
        private System.Windows.Forms.CheckBox chkChildShowProgress;
        private System.Windows.Forms.CheckBox chkChildShowNewFlag;
        private System.Windows.Forms.ComboBox cbChildViewDisplay;
        private System.Windows.Forms.Label lblChildViewDisplay;
        private System.Windows.Forms.ToolStripStatusLabel lblPath;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ToolStripSeparator tsmiSepRecent;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecent;
        private System.Windows.Forms.ToolStripMenuItem tsmiMove;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveOut;
        private System.Windows.Forms.ToolStrip tsHierarchyMove;
        private System.Windows.Forms.ToolStripButton tsbMoveUp;
        private System.Windows.Forms.ToolStripButton tsbMoveDown;
        private System.Windows.Forms.ToolStripButton tsbMoveOut;
        private System.Windows.Forms.ToolStripButton tsbMoveIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}

