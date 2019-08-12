namespace KunaApi.Services.Implements
{
    public class OptionsService : IOptionsService
    {
        public string PublicKey
            => Configuration.publicKey;

        public string SecretKey
            => Configuration.secretKey;
    }
}
