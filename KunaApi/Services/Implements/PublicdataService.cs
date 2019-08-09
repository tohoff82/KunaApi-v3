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

        public async Task<IEnumerable<Rate>> GetRatesAsync()
            => await HttpGetAsync<IEnumerable<Rate>>(new RateRequest());

        public async Task<Rate> GetRateAsync(string currencyName)
            => await HttpGetAsync<Rate>(new RateRequest(currencyName));
    }
}
