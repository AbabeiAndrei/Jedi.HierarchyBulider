using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class RecentProject : IEquatable<RecentProject>
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public DateTime Accesed { get; set; }

        public RecentProject()
        {
            Accesed = DateTime.Now;
        }

        public RecentProject(string path)
            : this()
        {
            Path = path;
            Name = System.IO.Path.GetFileName(path);
        }

        #region Equality members

        public bool Equals(RecentProject other)
        {
            return other != null && string.Equals(Name, other.Name) && string.Equals(Path, other.Path);
        }

        #endregion
    }
}
