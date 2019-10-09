using System;
using KunaApi.DTO.Bodies;

namespace KunaApi.POCO.Requests
{
    public class ExecutedOrdersRequest : KunaRequest
    {
        public ExecutedOrdersRequest(DateTime start, DateTime end, 
                                     ushort limit, sbyte sort) : base()
        {
            _path.Append("/auth/r/orders/hist");
            _requestBody = new ExecutedOrder
            {
                Start = ((DateTimeOffset)start).ToUnixTimeMilliseconds(),
                End = ((DateTimeOffset)end).ToUnixTimeMilliseconds(),
                Limit = limit,
                Sort = sort
            };
        }

        public ExecutedOrdersRequest(string marketMarker, DateTime start, 
                            DateTime end, ushort limit, sbyte sort) : base()
        {
            _path.AppendFormat("/auth/r/orders/{0}/hist", marketMarker);
            _requestBody = new ExecutedOrder
            {
                Start = ((DateTimeOffset)start).ToUnixTimeMilliseconds(),
                End = ((DateTimeOffset)end).ToUnixTimeMilliseconds(),
                Limit = limit,
                Sort = sort
            };
        }
    }
}
