using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;
using KunaApi.POCO.Requests;
using KunaApi.POCO;
using System.Linq;

namespace KunaApi.Services.Implements
{
    public class PublicdataService : KunaHttp, IPublicdataService
    {
        private readonly IModelbuilderService _modelbuilder;

        public PublicdataService(IModelbuilderService modelbuilder) : base()
            => _modelbuilder = modelbuilder;

        public async Task<Timestamp> GetTimestampAsync()
            => await HttpGetAsync<Timestamp>(new TimestampRequest());

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
            => await HttpGetAsync<IEnumerable<Currency>>(new CurrencyesRequest());

        public async Task<IEnumerable<Rate>> GetRatesAsync()
            => await HttpGetAsync<IEnumerable<Rate>>(new RateRequest());

        public async Task<Rate> GetRateAsync(string currencyName)
            => await HttpGetAsync<Rate>(new RateRequest(currencyName));

        public async Task<IEnumerable<Market>> GetMarketsAsync()
            => await HttpGetAsync<IEnumerable<Market>>(new MarketRequest());

        public async Task<IEnumerable<Ticker>> GetTickersAsync()
        {
            var crudeTickers = await HttpGetAsync<List<List<string>>>(new TickerRequest("ALL"));
            return _modelbuilder.CreateTickerList(crudeTickers);
        }

        public async Task<Ticker> GetTickerAsync(string marketMarker)
        {
            var crudeTickers = await HttpGetAsync<List<List<string>>>(new TickerRequest(marketMarker));
            return _modelbuilder.CreateTicker(crudeTickers.First());
        }
            
    }
}
