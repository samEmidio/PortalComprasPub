// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.



using PortalComprasPub.Domain.Interfaces;

namespace PortalComprasPub.Domain.Factory.MyEntity
{
    public abstract class MyEntityFactory
    {
        public abstract IMyEntity GetMyEntity(Enums.Type type);
    }

}
