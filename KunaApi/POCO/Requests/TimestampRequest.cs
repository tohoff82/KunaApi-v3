namespace KunaApi.POCO.Requests
{
    public class TimestampRequest : KunaRequest
    {
        public TimestampRequest() : base()
            => sb.Append("/timestamp");
    }
}
