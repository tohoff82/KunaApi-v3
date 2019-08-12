namespace KunaApi.Services
{
    public interface IOptionsService
    {
        string PublicKey { get; }
        string SecretKey { get; }
    }
}
