// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.



using Microsoft.Extensions.DependencyInjection;

using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;
using PortalComprasPub.Infrastructure.Data.Repositories;
using PortalComprasPub.Infrastructure.Data.UnitOfWork;

namespace PortalComprasPub.Infrastructure.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // Applicatio

            // Domain
            services.AddScoped<IMyEntityRepository, MyEntityRepository>();


            // Infra - Data
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<PortalContext>();

        }
    }
}
}
