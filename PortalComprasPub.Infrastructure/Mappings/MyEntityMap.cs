// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using System.Security.Cryptography.X509Certificates;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PortalComprasPub.Domain.Entities;

namespace PortalComprasPub.Infrastructure.Data.Mappings
{
    public class MyEntityMap : BaseEntityMap<MyEntity>
    {
        public override void Configure(EntityTypeBuilder<MyEntity> builder)
        {
            base.Configure(builder);
        }
    }
}
