using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils.Services
{
    public class HierarchySenderService
    {
        #region Fields

        private readonly string _apiUrl;

        #endregion

        #region Constructors

        public HierarchySenderService(string apiUrl)
        {
            if(string.IsNullOrEmpty(apiUrl))
                throw new ArgumentNullException(nameof(apiUrl));
            _apiUrl = apiUrl;
        }

        #endregion

        #region Public methods

        public async Task SendHierarchy(string json, int organisationId, string authorization)
        {
            var endpoint = $"{_apiUrl.TrimEnd('/')}/api/platform/organisation/{organisationId}/hierarchy";

            using (var client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", authorization);
                var response = await client.PostAsync(endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    throw new Exception(result.DefaultIfNull(response.ToString()));
                }
            }
        }

        #endregion
    }
}
