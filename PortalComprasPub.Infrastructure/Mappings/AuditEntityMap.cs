// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalComprasPub.Domain.Core.Entities;

namespace PortalComprasPub.Infrastructure.Data.Mappings
{
    public abstract class AuditEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : AuditEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {

        }
    }
}
