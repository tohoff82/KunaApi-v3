namespace KunaApi.POCO.Requests
{
    public class CurrencyesRequest : KunaRequest
    {
        public CurrencyesRequest() : base()
            => sb.Append("/currencies");
    }
}
