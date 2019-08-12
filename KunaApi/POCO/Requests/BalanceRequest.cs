namespace KunaApi.POCO.Requests
{
    public class BalanceRequest : KunaRequest
    {
        public BalanceRequest() : base()
        {
            sb.Append("/auth/r/wallets");
            crudeBody = new object();
        }
    }
}
