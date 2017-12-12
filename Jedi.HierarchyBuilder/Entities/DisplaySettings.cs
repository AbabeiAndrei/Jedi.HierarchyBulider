using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class DisplayModel
    {
        public MasterDisplayModel MasterDisplay { get; set; }
        public ChildDisplayModel ChildDisplay { get; set; }

        public DisplayModel()
        {
            MasterDisplay = new MasterDisplayModel();
            ChildDisplay = new ChildDisplayModel();
        }
    }
}
