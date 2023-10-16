// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using System.ComponentModel.DataAnnotations;

namespace PortalComprasPub.Domain.Core.Entities
{
    public class BaseEntity : AuditEntity
    {
        [Key]
        public int Id { get; set; }
        public Guid Identifier { get; set; } = Guid.NewGuid();
    }
}
