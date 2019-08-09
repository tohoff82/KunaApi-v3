using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Rate
    {
        [JsonProperty("currency")]
        public string BaseCurrency { get; set; }

        [JsonProperty("usd")]
        public float QuotedUSD { get; set; }

        [JsonProperty("uah")]
        public float QuotedUAH { get; set; }

        [JsonProperty("btc")]
        public float QuotedBTC { get; set; }

        [JsonProperty("eur")]
        public float QuotedEUR { get; set; }

        [JsonProperty("rub")]
        public float QuotedRUB { get; set; }
    }
}
