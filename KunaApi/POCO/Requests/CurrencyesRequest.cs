namespace KunaApi.POCO.Requests
{
    public class CurrencyesRequest : KunaRequest
    {
        public CurrencyesRequest() : base()
            => _path.Append("/currencies");
    }
}
