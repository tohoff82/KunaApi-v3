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
        private readonly IModelbuilderService _builder;

        public PublicdataService(IModelbuilderService builder) : base()
            => _builder = builder;

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

        public async Task<IEnumerable<Fee>> GetFeesAsync()
            => await HttpGetAsync<IEnumerable<Fee>>(new FeesRequest());

        public async Task<IEnumerable<Ticker>> GetTickersAsync(params string[] markers)
        {
            string[][] crudeTickers = await HttpGetAsync<string[][]>(new TickerRequest(markers));
            return _builder.CreateTickerList(crudeTickers);
        }

        public async Task<Ticker> GetTickerAsync(string marketMarker)
        {
            string[][] crudeTickers = await HttpGetAsync<string[][]>(new TickerRequest(marketMarker));
            return _builder.CreateTicker(crudeTickers.FirstOrDefault());
        }

        public async Task<Orderbook> GetOrderbookAsync(string marketMarker)
        {
            string[][] crudeOrderbook = await HttpGetAsync<string[][]>(new OrderbookRequest(marketMarker));
            return _builder.CreateOrderbook(crudeOrderbook);
        }
    }
}
