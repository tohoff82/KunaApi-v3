using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Order
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("market_marker")]
        public string MarketMarker { get; set; }

        [JsonProperty("creation_time")]
        public long CreationTime { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }

        [JsonProperty("volume")]
        public float Volume { get; set; }

        [JsonProperty("start_volume")]
        public float StartVolume { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } // LIMIT or MARKET

        [JsonProperty("status")]
        public string Status { get; set; } // ACTIVE, EXECUTED

        [JsonProperty("side")]
        public string Side { get; set; } // BUY, SELL

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("average_price")]
        public float AveragePrice { get; set; }
    }
}
