using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class GeneraEx
    {
        public static TResult Iif<TResult>(this bool condition, TResult onTrue, TResult onFalse)
        {
            return condition ? onTrue : onFalse;
        }

        public static int NumberOfDigits(this int number)
        {
            return number.ToString().Length;
        }
    }
}
