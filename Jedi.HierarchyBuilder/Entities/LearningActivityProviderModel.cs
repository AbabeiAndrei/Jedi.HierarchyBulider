using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    [Flags]
    public enum ProviderCategory
    {
        None = ProviderType.None,
        ElearningProviderType = ProviderType.Articulate | ProviderType.Captivate | ProviderType.Lectora,
        VideoProviderType = ProviderType.VideoFile | ProviderType.VideoVimeo,
        DocumentProviderType = ProviderType.Document
    }

    public class LearningActivityProviderModel
    {
        public int Id { get; set; }
        public string LaunchUrl { get; set; }
        public TinCanInformation TinCan { get; set; }
        /// <summary>
        /// Represents the version for a specific provider
        /// </summary>
        public virtual string Version { get; set; }
        public virtual ProviderCategory ProviderCategory { get; set; }
        public virtual ProviderType ProviderType { get; set; }

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime LastUpdate { get; set; }

        public LearningActivityProviderModel()
        {
            TinCan = new TinCanInformation();
        }
    }
}
