// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

namespace PortalComprasPub.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMyEntityRepository MyEntities { get; }
        int BeginTransaction();
        bool Save();
    }
}
