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
                .AddSingleton<IAccountServiece, AccountService>()
                .AddTransient<IModelbuilderService, ModelbuilderService>()
                .BuildServiceProvider();
        }

        public IPublicdataService Publicdata
            => provider.GetService<IPublicdataService>();

        public IAccountServiece Account
            => provider.GetService<IAccountServiece>();
    }
}
