using System.Collections.Generic;
using KunaApi.DTO.Answers;

using static System.Globalization.CultureInfo;
using static System.Globalization.NumberStyles;

namespace KunaApi.Services.Implements
{
    public class ModelbuilderService : IModelbuilderService
    {
        public IReadOnlyCollection<Ticker> CreateTickerList(List<List<string>> crudeTickers)
        {
            var tickerList = new List<Ticker>();
            
            foreach (var crudeTicker in crudeTickers)
            {
                tickerList.Add(new Ticker
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
                });
            }

            return tickerList;
        }
    }
}
