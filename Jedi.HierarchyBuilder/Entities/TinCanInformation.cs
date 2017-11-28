using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class TinCanInformation
    {
        /// <summary>
        /// The CourseID for a specific tincan package
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// The Name for a specific tincan package
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// The description for a specific tincan pacakge
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// The startup file for a specific tincan package
        /// </summary>
        public virtual string StartupEndpoint { get; set; }
    }
}
