using System;
using System.Collections.Generic;
using System.Text;

namespace KunaApi.POCO.Requests
{
    public class TimestampRequest : KunaRequest
    {
        public TimestampRequest() : base()
            => sb.Append("/timestamp");
    }
}
