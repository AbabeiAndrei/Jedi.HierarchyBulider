using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Jedi.HierarchyBuilder.Entities
{
    [Flags]
    public enum LearningActivityActivationState
    {
        None = 0,
        Active = 1,
        Inactive = 2,
        Archived = 4
    }

    [Flags]
    public enum ProviderType
    {
        None = 0,
        Articulate = 1,      // 000001
        Captivate = 1 << 1,  // 000010 = 2
        Lectora = 1 << 2,    // 000100 = 4
        VideoFile = 1 << 3,  // 001000 = 8
        VideoVimeo = 1 << 4, // 010000 = 16
        Document = 1 << 5,   // 100000 = 32
    }

    public class LearningActivity
    {
        private string _name;
        private ProviderType _packageProviderType;
        private string _tinCanId;
        private string _tinCanStartupFile;

        public IEnumerable<LearningActivity> Members { get; set; }

        public bool IsVisible { get; set; }

        public IEnumerable<CategoryModel> Categories { get; set; }

        //public LearningActivityVersion ActiveVersion { get; set; }
        
        public string CategoriesProxy
        {
            get
            {
                return string.Join(";", Categories.Select(cm => cm.Name));
            }
            set
            {
                Categories = value.Split(new [] {';'}, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(cat => new CategoryModel
                                  {
                                      Name = cat
                                  });
            }
        }

        public string GenericInfo { get; set; }

        public int ProgressVersion { get; set; }

        public LearningActivityRelation ParentRelation { get; set; }

        public string LrsEndpoint { get; set; }

        public ContainerPolicyViewModel PolicyModel { get; set; }

        public int Id { get; set; }

        public bool IsActivity { get; protected set; }

        public bool ResetUserActivityState { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                ActiveVersion.Provider.TinCan.Name = value;
            }
        }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string PackageName { get; set; }
        
        public string Filepath { get; set; }

        public int Organisation_Id { get; set; }

        public string GraphicsUrl { get; set; }

        public int Version { get; set; }

        public int State { get; set; }

        public int Group_Id { get; set; }

        public Guid ActivityArchive_Id { get; set; }
        public LearningActivityVersionModel ActiveVersion { get; set; }

        public ProviderType PackageProviderType
        {
            get
            {
                return _packageProviderType;
            }
            set
            {
                _packageProviderType = value;
                ActiveVersion.Provider.ProviderType = value;
            }
        }

        public LearningActivityActivationState ActivationState { get; set; }
        
        public string TinCan_Id
        {
            get
            {
                return _tinCanId;
            }
            set
            {
                _tinCanId = value;
                ActiveVersion.Provider.TinCan.Id = value;
            }
        }

        public string TinCan_StartupFile
        {
            get
            {
                return _tinCanStartupFile;
            }
            set
            {
                _tinCanStartupFile = value;
                ActiveVersion.Provider.TinCan.StartupEndpoint = value;
            }
        }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public int? CultureId { get; set; }

        #region Proxies
        
        public DisplayModel DisplaySettings { get; set; }

        [JsonIgnore]
        public int DisplayOrderProxy
        {
            get
            {
                return ParentRelation?.DisplayOrder ?? 0;
            }
            set
            {
                if (ParentRelation != null)
                    ParentRelation.DisplayOrder = value;
            }
        }

        [JsonIgnore]
        public bool IsMandatoryProxy
        {
            get
            {
                return ParentRelation?.IsMandatory ?? false;
            }
            set
            {
                if (ParentRelation != null)
                    ParentRelation.IsMandatory = value;
            }
        }

        [JsonIgnore]
        public ContainerPolicyType ContainerPolicyProxy
        {
            get
            {
                return PolicyModel?.ContainerPolicy ?? ContainerPolicyType.Optional;
            }
            set
            {
                if (PolicyModel != null)
                    PolicyModel.ContainerPolicy = value;
            }
        }

        [JsonIgnore]
        public int RequiredItemsCountProxy
        {
            get
            {
                return PolicyModel?.RequiredItemsCount ?? 0;
            }
            set
            {
                if (PolicyModel != null)
                    PolicyModel.RequiredItemsCount = value;
            }
        }

        [JsonIgnore]
        public AccessEnforcePolicyEnum AccessEnforcePolicyProxy
        {
            get
            {
                return PolicyModel?.AccessEnforcePolicy ?? AccessEnforcePolicyEnum.None;
            }
            set
            {
                if (PolicyModel != null)
                    PolicyModel.AccessEnforcePolicy = value;
            }
        }

        [JsonIgnore]
        public TransitionStates TransitionStateProxy
        {
            get
            {
                return ParentRelation?.TransitionState ?? TransitionStates.None;
            }
            set
            {
                if (ParentRelation != null)
                    ParentRelation.TransitionState = value;
            }
        }

        [JsonIgnore]
        public DisplayEnforcePolicyEnum DisplayEnforcePolicyProxy
        {
            get
            {
                return PolicyModel?.DisplayEnforcePolicy ?? DisplayEnforcePolicyEnum.ShowAll;
            }
            set
            {
                if (PolicyModel != null)
                    PolicyModel.DisplayEnforcePolicy = value;
            }
        }

        [JsonIgnore]
        public int AccessOrderProxy
        {
            get
            {
                return ParentRelation?.AccessOrder ?? 0;
            }
            set
            {
                if (ParentRelation != null)
                    ParentRelation.AccessOrder = value;
            }
        }

        #endregion

        public LearningActivity(bool isActivity, string name)
        {
            IsActivity = isActivity;

            IsVisible = true;
            ParentRelation = new LearningActivityRelation();
            PolicyModel = new ContainerPolicyViewModel();
            ActivityArchive_Id = Guid.Empty;
            CreationDate = DateTime.Now;
            LastUpdate = DateTime.Now;
            DisplaySettings = new DisplayModel();
            ActiveVersion = new LearningActivityVersionModel();
            Categories = Enumerable.Empty<CategoryModel>();

            Name = name;
            PackageProviderType = ProviderType.Lectora;
        }
    }
}
