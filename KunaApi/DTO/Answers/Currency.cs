﻿using Newtonsoft.Json;

namespace KunaApi.DTO.Answers
{
    public class Currency
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_memo")]
        public bool HasMemo { get; set; }

        [JsonProperty("icons")]
        public Icons Icons { get; set; }

        [JsonProperty("coin")]
        public bool AsCoin { get; set; }

        [JsonProperty("explorer_link")]
        public string ExplorerLinkTamplate { get; set; }

        [JsonProperty("sort_order")]
        public int Offset { get; set; }

        [JsonProperty("precision")]
        public Precision Precision { get; set; }
    }

    public class Icons
    {
        [JsonProperty("std")]
        public string Std { get; set; }

        [JsonProperty("xl")]
        public string Xl { get; set; }

        [JsonProperty("png_2x")]
        public string Png2x { get; set; }

        [JsonProperty("png_3x")]
        public string Png3x { get; set; }

    }

    public class Precision
    {
        [JsonProperty("real")]
        byte Real { get; set; }

        [JsonProperty("trade")]
        byte Trade { get; set; }
    }
}
