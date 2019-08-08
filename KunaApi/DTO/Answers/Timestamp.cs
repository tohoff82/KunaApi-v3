using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Timestamp
    {
        [JsonProperty("timestamp")]
        public long InSeconds { get; set; }

        [JsonProperty("timestamp_miliseconds")]
        public long InMiliseconds { get; set; }
    }
}
