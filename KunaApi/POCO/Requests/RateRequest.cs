namespace KunaApi.POCO.Requests
{
    public class RateRequest : KunaRequest
    {
        public RateRequest() : base()
            => sb.Append("/exchange-rates");

        public RateRequest(string currencyName) : this()
            => sb.Append(currencyName.ToLower());
    }
}
