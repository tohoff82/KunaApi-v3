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
            Configuration.publicKey = pubKey;
            Configuration.secretKey = secKey;

            provider = new ServiceCollection()
                .AddSingleton<IAccountServiece, AccountService>()
                .AddTransient<IOrdersService, OrdersService>()
                .AddTransient<IOptionsService, OptionsService>()
                .AddTransient<IModelbuilderService, ModelbuilderService>()
                .BuildServiceProvider();
        }

        public IPublicdataService Publicdata
            => provider.GetService<IPublicdataService>();

        public IAccountServiece Account
            => provider.GetService<IAccountServiece>();

        public IOrdersService Orders
            => provider.GetService<IOrdersService>();


    }

    public static class Configuration
    {
        // to do conect a key-value store azure
        public static string publicKey;
        public static string secretKey;
    }
}
