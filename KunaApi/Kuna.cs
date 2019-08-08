using KunaApi.Services;
using KunaApi.Services.Implements;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KunaApi
{
    public class Kuna
    {
        private readonly IServiceProvider provider;

        public Kuna()
        {
            provider = new ServiceCollection()
                .AddTransient<IPublicdataService, PublicdataService>()
                .BuildServiceProvider();
        }

        public IPublicdataService Publicdata
            => provider.GetService<IPublicdataService>();
    }
}
