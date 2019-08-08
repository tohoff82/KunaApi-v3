using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Timestamp
    {
        [JsonProperty("timestamp")]
        long InSeconds { get; set; }

        [JsonProperty("timestamp_miliseconds")]
        long InMiliseconds { get; set; }
    }
}
