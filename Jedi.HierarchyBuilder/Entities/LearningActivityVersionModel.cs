using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    [Flags]
    public enum LearningActivityVersionState
    {
        None = 0,
        Processing = 1,
        Staged = 2,
        Active = 4,
        Invalid = 8,
        Deleted = 16,
        Inactive = 32,
    }

    public class LearningActivityVersionModel
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public int VersionNumber { get; set; }

        public LearningActivityVersionState VersionState { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string VersionName { get; set; }

        public LearningActivityProviderModel Provider { get; set; }

        public LearningActivityVersionModel()
        {
            VersionNumber = 1;
            VersionState = LearningActivityVersionState.None;
            Provider = new LearningActivityProviderModel();
        }
    }
}
