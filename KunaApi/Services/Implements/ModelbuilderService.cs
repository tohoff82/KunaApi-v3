using System.Collections.Generic;
using KunaApi.DTO.Answers;

using static System.Globalization.CultureInfo;
using static System.Globalization.NumberStyles;

namespace KunaApi.Services.Implements
{    

    public class ModelbuilderService : IModelbuilderService
    {
        #region Orders Region
        public IEnumerable<Order> CreateOrders(string[][] crudeOrders)
        {
            var orders = new List<Order>();

            foreach (string[] crudeOrder in crudeOrders)
            {
                orders.Add(CreateOrder(crudeOrder));
            }

            return orders;
        }

        public Order CreateOrder(string[] crudeOrder)
        {
            var order = new Order
            {
                Id = long.Parse(crudeOrder[0], Any, InvariantCulture),
                MarketMarker = crudeOrder[3],
                CreationTime = long.Parse(crudeOrder[4], Any, InvariantCulture),
                UpdateTime = long.Parse(crudeOrder[5], Any, InvariantCulture),
                Volume = float.Parse(crudeOrder[6], Any, InvariantCulture),
                Type = crudeOrder[8],
                Status = crudeOrder[13],
                Price = float.Parse(crudeOrder[16], Any, InvariantCulture),
                AveragePrice = float.Parse(crudeOrder[17], Any, InvariantCulture)
            };

            float startVolume = float.Parse(crudeOrder[7], Any, InvariantCulture);

            if (startVolume < 0)
            {
                order.StartVolume = -startVolume;
                order.Side = "SELL";
            } else
            {
                order.StartVolume = startVolume;
                order.Side = "BUY";
            }
            return order;
        }

        #endregion

        #region Balance Region
        public IEnumerable<Balance> CreateBalances(string[][] crudeBalances)
        {
            var balances = new List<Balance>();

            foreach (string[] crudeBalance in crudeBalances)
            {
                balances.Add(CreateBalance(crudeBalance));
            }

            return balances;
        }

        private Balance CreateBalance(string[] crudeBalance)
            => new Balance
            {
                BalanceMarker = crudeBalance[0],
                CurrencyMarker = crudeBalance[1],
                FullBalace = float.Parse(crudeBalance[2], Any, InvariantCulture),
                AvailableFunds = float.Parse(crudeBalance[4], Any, InvariantCulture)
            };
        #endregion

        #region Ticker Region
        public Ticker CreateTicker(string[] crudeTicker)
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

        public IEnumerable<Ticker> CreateTickerList(string[][] crudeTickers)
        {
            var tickerList = new List<Ticker>();
            
            foreach (string[] crudeTicker in crudeTickers)
            {
                tickerList.Add(CreateTicker(crudeTicker));
            }

            return tickerList;
        }
        #endregion

        #region OrderBook Region
        public Orderbook CreateOrderbook(string[][] crudeOrderbook)
        {
            var bidCollection = new List<OrderbookItem>();
            var askCollection = new List<OrderbookItem>();

            foreach (string[] crudeOrderbookItem in crudeOrderbook)
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

        private OrderbookItem CreateOrderbookItem(string[] crudeOrderbookItem)
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
        #endregion
    }
}
