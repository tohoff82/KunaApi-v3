using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Account
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("kunaid")]
        public string KunaId { get; set; }

        [JsonProperty("two_factor")]
        public bool EnableTwoFactor { get; set; }

        [JsonProperty("withdraw_confirmation")]
        public bool WithdrawConfirmation { get; set; }

        [JsonProperty("public_keys")]
        public InputOutputKeys InputOutputKeys { get; set; }

        [JsonProperty("announcements")]
        public bool Announcements { get; set; }
    }

    public class InputOutputKeys
    {
        [JsonProperty("deposit_sdk_uah_public_key")]
        public string PublicKeyUAH { get; set; }

        [JsonProperty("deposit_sdk_usd_public_key")]
        public string PublicKeyUSD { get; set; }

        [JsonProperty("deposit_sdk_rub_public_key")]
        public string PublicKeyRUB { get; set; }
    }
}
