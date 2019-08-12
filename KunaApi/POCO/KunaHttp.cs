using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KunaApi.DTO.Answers;
using System.Security.Cryptography;
using System.Text;

namespace KunaApi.POCO
{
    public class KunaHttp
    {
        private readonly string baseUri = "https://api.kuna.io";
        private readonly string shema = "application/json";
        private readonly HttpClient httpClient;

        public KunaHttp()
        {
            httpClient = new HttpClient { BaseAddress = new Uri(baseUri) };
            httpClient.DefaultRequestHeaders.Add("Accept", shema);
        }

        protected async Task<T> HttpGetAsync<T>(KunaRequest request)
        {
            using (var response = await httpClient.GetAsync(request.Uri))
            {
                return await UnpackingResponseAsync<T>(response);
            }
        }

        protected async Task<T> HttpPostAsync<T>(KunaRequest request, string publicKey, string secretKey)
        {
            string nonce = Nonce.ToString();
            string signature = Encrypt(request.Signature(nonce), secretKey);
            UpdateHeaders(nonce, signature, publicKey);

            using (var response = await httpClient.PostAsync(request.Uri,
                new StringContent(request.Body, Encoding.UTF8, shema)))
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

        private string Encrypt(string signature, string secretKey)
        {
            using (var hmac = new HMACSHA384(Encoding.UTF8.GetBytes(secretKey)))
            {
                byte[] hashmessage = hmac.ComputeHash(Encoding.UTF8.GetBytes(signature));

                return BitConverter.ToString(hashmessage).Replace("-", string.Empty).ToLower();
            }
        }

        private long Nonce
            => DateTimeOffset.Now.ToUnixTimeMilliseconds();

        private void UpdateHeaders(string nonce, string signature, string pubKey)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.ConnectionClose = false;
            httpClient.DefaultRequestHeaders.Add("Kun-Signature", signature);
            httpClient.DefaultRequestHeaders.Add("Kun-ApiKey", pubKey);
            httpClient.DefaultRequestHeaders.Add("Kun-Nonce", nonce);
            httpClient.DefaultRequestHeaders.Add("Accept", shema);
        }
    }
}
