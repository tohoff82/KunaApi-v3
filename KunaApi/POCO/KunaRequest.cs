using System;
using System.Text;
using Newtonsoft.Json;

namespace KunaApi.POCO
{
    public class KunaRequest
    {
        private readonly string vers = "/v3";

        protected StringBuilder _path;
        protected object _requestBody;

        public KunaRequest()
            => _path = new StringBuilder(vers);

        public Uri Uri
            => new Uri(_path.ToString(), UriKind.Relative);

        public string Body
            => JsonConvert.SerializeObject(_requestBody);

        public string Signature(string nonce)
            => new StringBuilder(Uri.ToString())
            .AppendFormat("{0}{1}", nonce, Body)
            .ToString();
    }
}
