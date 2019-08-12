using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Balance
    {
        [JsonProperty("balance_marker")]
        public string BalanceMarker { get; set; }

        [JsonProperty("currency_marker")]
        public string CurrencyMarker { get; set; }

        [JsonProperty("full_balance")]
        public float FullBalace { get; set; }

        [JsonProperty("available_funds")]
        public float AvailableFunds { get; set; }
    }
}
