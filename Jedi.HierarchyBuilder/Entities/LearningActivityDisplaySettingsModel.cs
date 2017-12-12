using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class LearningActivityDisplaySettingsModel
    {
        /// <summary>
        /// ID of the associated learning activity
        /// </summary>
        public int ActivityId { get; set; }
        public DisplayModel DisplaySettings { get; set; }
    }
}
