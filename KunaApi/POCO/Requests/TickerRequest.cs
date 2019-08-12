namespace KunaApi.POCO.Requests
{
    public class TickerRequest : KunaRequest
    {
        private TickerRequest() : base()
            => _path.Append("/tickers");

        public TickerRequest(string marketMarker) : this()
            => _path.AppendFormat("?symbols={0}", marketMarker);
    }
}
