// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using PortalComprasPub.Domain.Entities;
using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;

namespace PortalComprasPub.Infrastructure.Data.Repositories
{
    public class MyEntityRepository : BaseRepository<MyEntity>, IMyEntityRepository
    {
        protected readonly PortalContext _context;

        public MyEntityRepository(PortalContext context)
            : base(context)
        {
            _context = context;
        }

    }
}


