namespace KunaApi.POCO.Requests
{
    public class OrderbookRequest : KunaRequest
    {
        public OrderbookRequest(string marketMarker) : base()
            => sb.AppendFormat("/book/{0}", marketMarker);
    }
}
