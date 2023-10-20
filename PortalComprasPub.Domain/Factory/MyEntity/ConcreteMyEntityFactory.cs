// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.



using PortalComprasPub.Domain.Interfaces;

namespace PortalComprasPub.Domain.Factory.MyEntity
{
    public class ConcreteMyEntityFactory : MyEntityFactory
    {
        public override IMyEntity GetMyEntity(Enums.Type type)
        {
            return type switch
            {
                Enums.Type.entity0 => new Entities.MyEntity(),
                Enums.Type.entity1 => new Entities.MyEntity(),
                _ => throw new ApplicationException($"Entity {type} cannot be created"),
            };
        }
    }
}
