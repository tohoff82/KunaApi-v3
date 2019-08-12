namespace KunaApi.POCO.Requests
{
    public class BalanceRequest : KunaRequest
    {
        public BalanceRequest() : base()
        {
            _path.Append("/auth/r/wallets");
            _bodyody = new object();
        }
    }
}
