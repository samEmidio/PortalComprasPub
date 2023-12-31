// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;
using PortalComprasPub.Domain.Entities;
using PortalComprasPub.Domain.Factory.MyEntity;
using PortalComprasPub.Domain.Interfaces;

namespace PortalComprasPub.Application.Services
{
    public class MyEntityAppService : IMyEntityAppService
    {
        private readonly IUnitOfWork _uow;
        private readonly MyEntityCreateViewModelValidation _myEntityCreateValidation;

        public MyEntityAppService(IUnitOfWork unitOfWork, MyEntityCreateViewModelValidation myEntityCreateValidation)
        {
            _uow = unitOfWork;
            _myEntityCreateValidation = myEntityCreateValidation;

        }

        public MyEntityViewModel? Add(MyEntityCreateViewModel myEntityViewModel)
        {
            try
            {

                if (!_myEntityCreateValidation.Validate(myEntityViewModel).IsValid)
                    return null;

                MyEntityFactory factory = new ConcreteMyEntityFactory();
                var entityfactory = factory.GetMyEntity(myEntityViewModel.Age >= 18 ? Domain.Enums.Type.entity0 : Domain.Enums.Type.entity1);
                var entity = entityfactory.Create(myEntityViewModel.Name, myEntityViewModel.LastName, myEntityViewModel.Age);


                _uow.MyEntities.Add(entity);

                _uow.Save();

                return new MyEntityViewModel { Age = entity.Age, Name = entity.Name.FirstName, Identifier = entity.Identifier };

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
