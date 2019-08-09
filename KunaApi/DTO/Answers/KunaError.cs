using System.Collections.Generic;
using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class KunaError
    {
        [JsonProperty("messages")]
        public ICollection<string> Errors { get; set; }
    }
}
