namespace KunaApi.POCO.Requests
{
    public class OrderbookRequest : KunaRequest
    {
        public OrderbookRequest(string marketMarker) : base()
            => _path.AppendFormat("/book/{0}", marketMarker);
    }
}
