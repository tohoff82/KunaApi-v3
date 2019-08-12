namespace KunaApi.POCO.Requests
{
    public class ExecutedOrderRequest : KunaRequest
    {
        public ExecutedOrderRequest(string marketMarker) : base()
        {
            _path.AppendFormat("/auth/r/orders/{0}/hist", marketMarker);
            _requestBody = new object();
        }
    }
}
