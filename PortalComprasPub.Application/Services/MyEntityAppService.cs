// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;
using PortalComprasPub.Domain.Interfaces;

namespace PortalComprasPub.Application.Services
{
    public class MyEntityAppService : IMyEntityAppService
    {
        private readonly IUnitOfWork _uow;

        public MyEntityAppService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public MyEntityViewModel Add(MyEntityCreateViewModel myEntityViewModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid identifier)
        {
            throw new NotImplementedException();
        }

        public MyEntityViewModel Get(Guid identifier)
        {
            throw new NotImplementedException();
        }

        public MyEntityUpdateViewModel Update(MyEntityUpdateViewModel myEntityViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
