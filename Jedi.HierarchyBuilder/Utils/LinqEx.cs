using System.Linq;
using System.Collections.Generic;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class LinqEx
    {
        public static IList<T> Splice<T>(this IEnumerable<T> source, int position)
        {
            return position > 0 
                    ? new List<T>(source.Take(position)) 
                    : new List<T>();
        }
    }
}
