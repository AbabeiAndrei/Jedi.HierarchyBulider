#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class DebugUtils
    {
        public static void Dump<T>(this T obj)
        {
            var str = JsonConvert.SerializeObject(obj, Formatting.Indented);

            MessageBox.Show(str,
                            typeof(T).FullName + " - " + nameof(obj),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}

#endif