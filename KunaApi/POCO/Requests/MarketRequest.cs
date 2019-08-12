namespace KunaApi.POCO.Requests
{
    public class MarketRequest : KunaRequest
    {
        public MarketRequest() : base()
            => _path.Append("/markets");
    }
}
