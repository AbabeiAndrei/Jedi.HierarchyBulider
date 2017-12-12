using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils.Services
{
    public class Service
    {
        protected string ApiUrl { get; }

        protected Service(string apiUrl)
        {
            if (string.IsNullOrEmpty(apiUrl))
                throw new ArgumentNullException(nameof(apiUrl));

            ApiUrl = apiUrl;
        }
    }
}
