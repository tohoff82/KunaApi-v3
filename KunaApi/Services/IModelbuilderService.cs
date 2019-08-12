using KunaApi.DTO.Answers;
using System.Collections.Generic;

namespace KunaApi.Services
{
    public interface IModelbuilderService
    {
        Ticker CreateTicker(string[] crudeTicker);
        IEnumerable<Ticker> CreateTickerList(string[][] crudeTickers);
        Orderbook CreateOrderbook(string[][] crudeOrderbook);
        IEnumerable<Balance> CreateBalances(string[][] crudeBalances);
    }
}
