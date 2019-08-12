namespace KunaApi.POCO.Requests
{
    public class ActiveOrdersRequest : KunaRequest
    {
        public ActiveOrdersRequest(string marketMarker) : base()
        {
            _path.AppendFormat("/auth/r/orders/?{0}", marketMarker);
            _requestBody = new object();
        }
    }
}
