using Newtonsoft.Json;
using System.Collections.Generic;

namespace KunaApi.DTO.Answers
{
    public class Fee
    {
        [JsonProperty("code")]
        public string CurrencyMarker { get; set; }

        [JsonProperty("category")]
        public string CurrencyCategory { get; set; }

        [JsonProperty("deposit_fees")]
        public ICollection<Restrict> DepositFee { get; set; }

        [JsonProperty("withdraw_fees")]
        public ICollection<Restrict> WithdrawFee { get; set; }

        [JsonProperty("min_deposit")]
        public Asset MinDeposit { get; set; }

        [JsonProperty("min_withdraw")]
        public Asset MinWithdraw { get; set; }
    }

    public class Restrict
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("asset")]
        public Asset Asset { get; set; }
    }

    public class Asset
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("to_usd")]
        public float ToUSD { get; set; }
    }
}
