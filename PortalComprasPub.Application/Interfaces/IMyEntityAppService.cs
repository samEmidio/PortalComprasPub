// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.



using PortalComprasPub.Application.ViewModels.MyEntityViewModel;

namespace PortalComprasPub.Application.Interfaces
{
    public interface IMyEntityAppService
    {
        MyEntityViewModel Add(MyEntityCreateViewModel myEntityViewModel);
        MyEntityUpdateViewModel Update(MyEntityUpdateViewModel myEntityViewModel);
        MyEntityViewModel Get(Guid identifier);
        bool Delete(Guid identifier);
    }
}
