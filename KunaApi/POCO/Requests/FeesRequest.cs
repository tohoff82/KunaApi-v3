namespace KunaApi.POCO.Requests
{
    public class FeesRequest : KunaRequest
    {
        public FeesRequest() : base()
            => _path.Append("/fees");
    }
}
