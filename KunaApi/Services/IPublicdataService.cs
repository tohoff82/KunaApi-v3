using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;

namespace KunaApi.Services
{
    public interface IPublicdataService
    {
        Task<Timestamp> GetTimestampAsync();
        Task<IEnumerable<Currency>> GetCurrenciesAsync();
        Task<IEnumerable<Rate>> GetRatesAsync();
        Task<Rate> GetRateAsync(string currencyName);
    }
}
