namespace KunaApi.POCO.Requests
{
    public class AccountRequest : KunaRequest
    {
        public AccountRequest() : base()
        {
            sb.Append("/auth/me");
            crudeBody = new object();
        }
    }
}
