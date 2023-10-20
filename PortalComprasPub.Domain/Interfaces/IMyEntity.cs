// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using PortalComprasPub.Domain.Entities;

namespace PortalComprasPub.Domain.Interfaces
{
    public interface IMyEntity
    {
        MyEntity Create(string name, string lastName, int age);
    }
}
