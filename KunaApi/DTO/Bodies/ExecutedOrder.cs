using Newtonsoft.Json;

namespace KunaApi.DTO.Bodies
{
    public class ExecutedOrder
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("limit")]
        public ushort Limit { get; set; }

        [JsonProperty("sort")]
        public sbyte Sort { get; set; }
    }
}
