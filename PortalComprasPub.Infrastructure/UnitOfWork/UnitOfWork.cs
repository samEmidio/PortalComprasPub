// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;

namespace PortalComprasPub.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortalContext _context;
        private int _transactionCount;

        public UnitOfWork(PortalContext context,
            IMyEntityRepository myEntities
        )
        {
            _context = context;
            MyEntities = myEntities;
        }

        public IMyEntityRepository MyEntities { get; private set; }


        public bool Save()
        {
            if (_transactionCount <= 1)
            {
                _transactionCount = 0;
                return _context.SaveChanges() > 0;
            }

            _transactionCount--;
            return true;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int BeginTransaction()
        {
            return ++_transactionCount;
        }
    }
}
