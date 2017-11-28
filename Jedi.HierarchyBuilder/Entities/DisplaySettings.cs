using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class DisplaySettings
    {
        public virtual MasterDisplayModel MasterDisplay { get; set; }
        public virtual ChildDisplayModel ChildDisplay { get; set; }
    }
}
