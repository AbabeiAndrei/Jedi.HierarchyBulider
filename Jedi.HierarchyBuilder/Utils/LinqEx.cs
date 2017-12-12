using System;
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

        public static int FindIndex<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if(source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var index = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                    return index;
                index++;
            }

            return -1;
        }

        public static void Move<T>(this IList<T> source, int oldIndex, int newIndex)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var item = source[oldIndex];
            source.RemoveAt(oldIndex);
            source.Insert(newIndex, item);
        }
    }
}
