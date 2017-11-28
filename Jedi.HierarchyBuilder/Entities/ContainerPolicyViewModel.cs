using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{

    [Flags]
    public enum AccessEnforcePolicyEnum
    {
        None = 0,
        HardEnforce = 1,
    }

    [Flags]
    public enum DisplayEnforcePolicyEnum
    {
        ShowAll = 0,
        ShowNonAccessibleItems = 1,
        HideNonAccessibleItems = 2,
    }

    [Flags]
    public enum ContainerPolicyType
    {
        Optional = 0,
        XOutOf = 1,
        MarkedMandatory = 2,
    }

    public class ContainerPolicyViewModel
    {
        public ContainerPolicyType ContainerPolicy { get; set; }
        public AccessEnforcePolicyEnum AccessEnforcePolicy { get; set; }
        public DisplayEnforcePolicyEnum DisplayEnforcePolicy { get; set; }
        public int RequiredItemsCount { get; set; }

        public ContainerPolicyViewModel()
        {
            ContainerPolicy = ContainerPolicyType.Optional;
            AccessEnforcePolicy = AccessEnforcePolicyEnum.None;
            DisplayEnforcePolicy = DisplayEnforcePolicyEnum.ShowAll;
        }
    }
}
