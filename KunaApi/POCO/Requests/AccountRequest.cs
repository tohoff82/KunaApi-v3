namespace KunaApi.POCO.Requests
{
    public class AccountRequest : KunaRequest
    {
        public AccountRequest() : base()
        {
            _path.Append("/auth/me");
            _bodyody = new object();
        }
    }
}
