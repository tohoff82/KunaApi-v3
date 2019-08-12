namespace KunaApi.Services
{
    public interface IAuthconfigService
    {
        string PublicKey { get; }
        string SecretKey { get; }
    }
}
