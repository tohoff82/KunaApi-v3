namespace KunaApi.Services.Implements
{
    public class AuthconfigService : IAuthconfigService
    {
        public string PublicKey
            => Authconfig.publicKey;

        public string SecretKey
            => Authconfig.secretKey;
    }
}
