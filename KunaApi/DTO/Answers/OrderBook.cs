using Newtonsoft.Json;
using System.Collections.Generic;

namespace KunaApi.DTO.Answers
{
    [JsonArray]
    public class Orderbook
    {
        [JsonProperty("bid")]
        public ICollection<OrderbookItem> BidCollection { get; set; }

        [JsonProperty("ask")]
        public ICollection<OrderbookItem> AskCollection { get; set; }
    }

    public class OrderbookItem
    {
        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("volume")]
        public float Volume { get; set; }

        [JsonProperty("quantity")]
        public short Quantity { get; set; }
    }
}
