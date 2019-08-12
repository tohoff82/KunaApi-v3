using System;
using System.Text;
using Newtonsoft.Json;

namespace KunaApi.POCO
{
    public class KunaRequest
    {
        private readonly string vers = "/v3";

        protected StringBuilder sb;
        protected object crudeBody;

        public KunaRequest()
            => sb = new StringBuilder(vers);

        public Uri Uri
            => new Uri(sb.ToString(), UriKind.Relative);

        public string Body
            => JsonConvert.SerializeObject(crudeBody);

        public string Signature(string nonce)
            => new StringBuilder(Uri.ToString())
            .AppendFormat("{0}{1}", nonce, Body)
            .ToString();
    }
}
