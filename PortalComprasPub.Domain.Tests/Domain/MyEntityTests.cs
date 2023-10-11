// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


namespace PortalComprasPub.Domain.Tests.Domain
{

    public class MyEntityTests
    {
        [Fact]
        public void Is_Not_Null()
        {

            // Arrange
            int number = 2;
            bool expected = true;

            MyEntity entity = new(number);

            // Act
            var result = entity.IsEven();

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
