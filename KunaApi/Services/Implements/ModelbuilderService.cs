using System.Collections.Generic;
using KunaApi.DTO.Answers;

using static System.Globalization.CultureInfo;
using static System.Globalization.NumberStyles;

namespace KunaApi.Services.Implements
{    

    public class ModelbuilderService : IModelbuilderService
    {
        public IReadOnlyCollection<Balance> CreateBalances(List<List<string>> crudeBalances)
        {
            var balances = new List<Balance>();

            foreach (var crudeBalance in crudeBalances)
            {
                balances.Add(CreateBalance(crudeBalance));
            }

            return balances;
        }

        private Balance CreateBalance(List<string> crudeBalance)
            => new Balance
            {
                BalanceMarker = crudeBalance[0],
                CurrencyMarker = crudeBalance[1],
                FullBalace = float.Parse(crudeBalance[2], Any, InvariantCulture),
                AvailableFunds = float.Parse(crudeBalance[4], Any, InvariantCulture)
            };


        public Ticker CreateTicker(List<string> crudeTicker)
            => new Ticker
            {
                MarketMarker = crudeTicker[0],
                BidPrice = float.Parse(crudeTicker[1], Any, InvariantCulture),
                BidVolume = float.Parse(crudeTicker[2], Any, InvariantCulture),
                AskPrice = float.Parse(crudeTicker[3], Any, InvariantCulture),
                AskVolume = float.Parse(crudeTicker[4], Any, InvariantCulture),
                QuoteDalyPriceChangeAbsolute = float.Parse(crudeTicker[5], Any, InvariantCulture),
                QuoteDalyPriceChangePercent = float.Parse(crudeTicker[6], Any, InvariantCulture),
                LastPrice = float.Parse(crudeTicker[7], Any, InvariantCulture),
                BaseDalyVolume = float.Parse(crudeTicker[8], Any, InvariantCulture),
                MaxDalyPrice = float.Parse(crudeTicker[9], Any, InvariantCulture),
                MinDalyPrice = float.Parse(crudeTicker[10], Any, InvariantCulture)
            };

        public IReadOnlyCollection<Ticker> CreateTickerList(List<List<string>> crudeTickers)
        {
            var tickerList = new List<Ticker>();
            
            foreach (var crudeTicker in crudeTickers)
            {
                tickerList.Add(CreateTicker(crudeTicker));
            }

            return tickerList;
        }

        public Orderbook CreateOrderbook(List<List<string>> crudeOrderbook)
        {
            var bidCollection = new List<OrderbookItem>();
            var askCollection = new List<OrderbookItem>();

            foreach (var crudeOrderbookItem in crudeOrderbook)
            {
                var item = CreateOrderbookItem(crudeOrderbookItem);
                if (item.Volume > 0) bidCollection.Add(item);
                else askCollection.Add(ConvertOrderbookItem(item));
            }

            return new Orderbook
            {
                BidCollection = bidCollection,
                AskCollection = askCollection
            };
        }

        private OrderbookItem CreateOrderbookItem(List<string> crudeOrderbookItem)
            => new OrderbookItem
            {
                Price = float.Parse(crudeOrderbookItem[0], Any, InvariantCulture),
                Volume = float.Parse(crudeOrderbookItem[1], Any, InvariantCulture),
                Quantity = short.Parse(crudeOrderbookItem[2], Any, InvariantCulture)
            };

        private OrderbookItem ConvertOrderbookItem(OrderbookItem obi)
            => new OrderbookItem
            {
                Price = obi.Price,
                Volume = -obi.Volume,
                Quantity = obi.Quantity
            };
    }
}
