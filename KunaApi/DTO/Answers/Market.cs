using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Market
    {
        [JsonProperty("id")]
        public string MarketMarker { get; set; }

        [JsonProperty("base_unit")]
        public string BaseUnitMarker { get; set; }

        [JsonProperty("quote_unit")]
        public string QuoteUnitMarker { get; set; }

        [JsonProperty("base_precision")]
        public byte BasePrecision { get; set; }

        [JsonProperty("quote_precision")]
        public byte QuotePrecision { get; set; }

        [JsonProperty("display_precision")]
        public sbyte DisplayPrecision { get; set; }

        [JsonProperty("price_change")]
        public float PriceChange { get; set; }
    }
}
