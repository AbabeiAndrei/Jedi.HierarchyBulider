using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public interface IValidatable
    {
        IReadOnlyCollection<Exception> Validate();
    }
}
