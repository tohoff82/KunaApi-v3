namespace KunaApi.POCO.Requests
{
    public class RateRequest : KunaRequest
    {
        public RateRequest() : base()
            => _path.Append("/exchange-rates");

        public RateRequest(string currencyName) : this()
            => _path.AppendFormat("/{0}", currencyName.ToLower());
    }
}
