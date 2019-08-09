using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KunaApi.DTO.Answers;

namespace KunaApi.POCO
{
    public class KunaHttp
    {
        private readonly string baseUri = "https://api.kuna.io";
        private readonly HttpClient httpClient;

        public KunaHttp()
        {
            httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        protected async Task<T> HttpGetAsync<T>(KunaRequest request)
        {
            using (var response = await httpClient.GetAsync(request.Uri))
            {
                return await UnpackingResponseAsync<T>(response);
            }
        }

        private async Task<T> UnpackingResponseAsync<T>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();

            CheckStatus(response.IsSuccessStatusCode, json);

            return JsonConvert.DeserializeObject<T>(json);
        }

        private void CheckStatus(bool isOK, string json)
        {
            if (!isOK)
            {
                var answ = JsonConvert.DeserializeObject<KunaError>(json);
                throw new Exception(answ.Errors.FirstOrDefault());
            }
        }
    }
}
