using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JsonApiSerializer;
using Newtonsoft.Json;
using JsonApiClient.Models;
using System.IO;
using System.Text;

namespace JsonApiClient.Services
{
    public class JsonApiService : IJsonApiService
    {
        static HttpClient httpClient;
        static Uri baseAddress = new Uri("http://localhost:5000/api/v1/");
        static JsonApiSerializerSettings jsonApiSettings;

        public JsonApiService()
        {
            httpClient = new HttpClient()
            {
                BaseAddress = baseAddress
            };

            jsonApiSettings = new JsonApiSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
            };
        }

        public async Task<List<Person>> GetPeople()
        {
            var response = await httpClient.GetAsync("People");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Person>>(content, jsonApiSettings);
        }

        public async Task<Person> PostPersonAsync()
        {
            var person = new Person()
            {
                name = Path.GetRandomFileName()
            };

            var jsonContent = JsonConvert.SerializeObject(person, jsonApiSettings);
            var postContent = new StringContent(jsonContent);
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.api+json");

            var response = await httpClient.PostAsync("People", postContent);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Person>(content, jsonApiSettings);
        }
    }
}
