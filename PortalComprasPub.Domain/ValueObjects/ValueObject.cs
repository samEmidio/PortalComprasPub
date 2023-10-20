// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using System.ComponentModel.DataAnnotations;

namespace PortalComprasPub.Domain.ValueObjects
{
    public record ValueObject
    {
        [Key]
        public int Key { get; set; }
    }
}
