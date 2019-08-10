using KunaApi.DTO.Answers;
using System.Collections.Generic;

namespace KunaApi.Services
{
    public interface IModelbuilderService
    {
        Ticker CreateTicker(List<string> crudeTicker);
        IReadOnlyCollection<Ticker> CreateTickerList(List<List<string>> crudeTickers);
        OrderBook CreateOrderbook(List<List<string>> crudeOrderbook);
    }
}
