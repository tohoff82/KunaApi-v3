namespace KunaApi.POCO.Requests
{
    public class TimestampRequest : KunaRequest
    {
        public TimestampRequest() : base()
            => _path.Append("/timestamp");
    }
}
