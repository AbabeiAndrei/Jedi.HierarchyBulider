using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Jedi.HierarchyBuilder.Entities;

namespace Jedi.HierarchyBuilder.Utils.Services
{
    public class OrganisationService : Service
    {
        #region Constructors

        public OrganisationService(string apiUrl)
            : base(apiUrl)
        {
        }

        #endregion

        #region Public methods

        public async Task<IEnumerable<OrganisationModel>> Get(string authorization)
        {
            var endpoint = $"{ApiUrl.TrimEnd('/')}/api/organisations";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", authorization);
                var response = await client.GetAsync(endpoint);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    throw new Exception(result.DefaultIfNull(response.ToString()));

                var jsonObj = JsonConvert.DeserializeObject(result) as JObject;

                if (jsonObj == null)
                    throw new Exception("Unknow response type");

                return jsonObj["items"].ToObject<IEnumerable<OrganisationModel>>();
            }
        }

        #endregion
    }
}
