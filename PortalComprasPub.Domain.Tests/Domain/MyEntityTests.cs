// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


namespace PortalComprasPub.Domain.Tests.Domain
{

    public class MyEntityTests
    {
        [Fact]
        public void Is_Not_Adult()
        {

            // Arrange
            int age = 17;
            bool expected = false;

            MyEntity entity = new("joaozinho", "silva", age);

            // Act
            var result = entity.IsAdult();

            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Is_Adult()
        {

            // Arrange
            int age = 18;
            bool expected = true;

            MyEntity entity = new("joaozinho", "silva", age);

            // Act
            var result = entity.IsAdult();

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
