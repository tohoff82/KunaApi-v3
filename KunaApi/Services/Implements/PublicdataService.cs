using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;
using KunaApi.POCO.Requests;
using KunaApi.POCO;

namespace KunaApi.Services.Implements
{
    public class PublicdataService : KunaHttp, IPublicdataService
    {
        public PublicdataService() : base() { }

        public async Task<Timestamp> GetTimestampAsync()
            => await HttpGetAsync<Timestamp>(new TimestampRequest());
    }
}
