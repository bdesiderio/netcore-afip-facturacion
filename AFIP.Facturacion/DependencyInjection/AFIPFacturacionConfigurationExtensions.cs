using AFIP.Facturacion.Configuration;
using AFIP.Facturacion.Services;
using AFIP.Facturacion;
using AFIP.Facturacion.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFIP.Facturacion.DependencyInjection
{
    public static class AFIPFacturacionConfigurationExtensions
    {
        public static IServiceCollection AddAFIPConfiguration(this IServiceCollection services, Action<AFIPConfigurationOption> options)
        {
            services.Configure(options);

            services.AddSingleton<IAFIPFacturacionService, AFIPFacturacionService>();
            services.AddSingleton<LoginCmsClient>();
            services.AddSingleton<WsfeClient>();

            return services;
        }
    }
}
