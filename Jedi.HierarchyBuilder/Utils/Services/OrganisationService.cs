using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Jedi.HierarchyBuilder.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jedi.HierarchyBuilder.Utils.Services
{
    public class OrganisationService
    {
        private readonly string _apiUrl;

        public OrganisationService(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public async Task<IEnumerable<OrganisationModel>> Get(string authorization)
        {
            var endpoint = $"{_apiUrl.TrimEnd('/')}/api/organisations";

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
    }
}
