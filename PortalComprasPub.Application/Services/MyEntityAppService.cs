// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;
using PortalComprasPub.Domain.Entities;
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

        public MyEntityViewModel? Add(MyEntityCreateViewModel myEntityViewModel)
        {
            try
            {
                var entity = new MyEntity(myEntityViewModel.Name, myEntityViewModel.Age);

                _uow.MyEntities.Add(entity);

                _uow.Save();

                return new MyEntityViewModel { Age = entity.Age, Name = entity.Name, Identifier = entity.Identifier };

            }
            catch (Exception)
            {
                return null;
            }
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
