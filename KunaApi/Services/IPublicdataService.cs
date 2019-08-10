using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;

namespace KunaApi.Services
{
    public interface IPublicdataService
    {
        Task<Timestamp> GetTimestampAsync();
        Task<Rate> GetRateAsync(string currencyName);
        Task<IEnumerable<Rate>> GetRatesAsync();
        Task<IEnumerable<Currency>> GetCurrenciesAsync();
        Task<IEnumerable<Market>> GetMarketsAsync();
        Task<IEnumerable<Ticker>> GetTickersAsync();
        Task<IEnumerable<Fee>> GetFeesAsync();
        Task<Ticker> GetTickerAsync(string marketMarker);
        Task<Orderbook> GetOrderbookAsync(string marketMarker);
    }
}
