namespace KunaApi.POCO.Requests
{
    public class FeesRequest : KunaRequest
    {
        public FeesRequest() : base()
            => sb.Append("/fees");
    }
}
