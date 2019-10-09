using KunaApi.Extensions;

namespace KunaApi.POCO.Requests
{
    public class TickerRequest : KunaRequest
    {
        public TickerRequest(string[] marketMmarkers) : base()
        {
            if (marketMmarkers == null) _path.Append("/tickers?symbols=ALL");
            else _path.AppendFormat("/tickers?symbols={0}", marketMmarkers.Separate(","));
        }

        public TickerRequest(string marketMarker)
            => _path.AppendFormat("/tickers?symbols={0}", marketMarker);
    }
}
