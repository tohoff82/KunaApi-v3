namespace KunaApi.POCO.Requests
{
    public class MarketRequest : KunaRequest
    {
        public MarketRequest() : base()
            => sb.Append("/markets");
    }
}
