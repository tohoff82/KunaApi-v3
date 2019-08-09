using System;
using System.Text;
using System.Collections.Generic;

namespace KunaApi.POCO.Requests
{
    public class KunaRequest
    {
        private readonly string vers = "/v3";
        protected StringBuilder sb;

        public KunaRequest()
            => sb = new StringBuilder(vers);

        public Uri Uri
            => new Uri(sb.ToString(), UriKind.Relative);
    }
}
