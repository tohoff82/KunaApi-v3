using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Ticker
    {
        [JsonProperty("market_marker")]
        public string MarketMarker { get; set; }

        [JsonProperty("bid_price")]
        public float BidPrice { get; set; }

        [JsonProperty("bid_volume")]
        public float BidVolume { get; set; }

        [JsonProperty("ask_price")]
        public float AskPrice { get; set; }

        [JsonProperty("ask_volume")]
        public float AskVolume { get; set; }

        [JsonProperty("quote_daly_price_change_absolute")]
        public float QuoteDalyPriceChangeAbsolute { get; set; }

        [JsonProperty("quote_daly_price_change_perсent")]
        public float QuoteDalyPriceChangePercent { get; set; }

        [JsonProperty("last_price")]
        public float LastPrice { get; set; }

        [JsonProperty("base_daly_volume")]
        public float BaseDalyVolume { get; set; }

        [JsonProperty("max_daly_price")]
        public float MaxDalyPrice { get; set; }

        [JsonProperty("min_daly_price")]
        public float MinDalyPrice { get; set; }
    }
}
