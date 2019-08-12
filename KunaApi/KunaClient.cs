using System;
using KunaApi.Services;
using KunaApi.Services.Implements;
using Microsoft.Extensions.DependencyInjection;

namespace KunaApi
{
    public class KunaClient
    {
        private readonly IServiceProvider provider;

        public KunaClient()
        {
            provider = new ServiceCollection()
                .AddSingleton<IPublicdataService, PublicdataService>()
                .AddTransient<IModelbuilderService, ModelbuilderService>()
                .BuildServiceProvider();
        }

        public KunaClient(string pubKey, string secKey)
        {
            Authconfig.publicKey = pubKey;
            Authconfig.secretKey = secKey;

            provider = new ServiceCollection()
                .AddSingleton<IAccountServiece, AccountService>()
                .AddTransient<IAuthconfigService, AuthconfigService>()
                .AddTransient<IModelbuilderService, ModelbuilderService>()
                .BuildServiceProvider();
        }

        public IPublicdataService Publicdata
            => provider.GetService<IPublicdataService>();

        public IAccountServiece Account
            => provider.GetService<IAccountServiece>();
    }

    public static class Authconfig
    {
        public static string publicKey;
        public static string secretKey;
    }
}
