using System.Collections.Generic;
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

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
            => await HttpGetAsync<IEnumerable<Currency>>(new CurrencyesRequest());
    }
}
