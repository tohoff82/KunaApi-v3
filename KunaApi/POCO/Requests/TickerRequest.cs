namespace KunaApi.POCO.Requests
{
    public class TickerRequest : KunaRequest
    {
        private TickerRequest() : base()
            => sb.Append("/tickers");

        public TickerRequest(string marketMarker) : this()
            => sb.AppendFormat("?symbols={0}", marketMarker);
    }
}
