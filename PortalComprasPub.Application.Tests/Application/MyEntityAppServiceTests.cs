// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using Microsoft.EntityFrameworkCore;
using Moq;
using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;
using PortalComprasPub.Domain.Entities;
using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;


namespace PortalComprasPub.Application.Tests.Application
{
    public class MyEntityAppServiceTests
    {
        private readonly Mock<PortalContext> _context;
        private readonly Mock<IMyEntityRepository> _myEntityRepository;
        private readonly Mock<IUnitOfWork> _uow;
        private readonly Mock<IMyEntityAppService> _myEntityAppService;
        public MyEntityAppServiceTests()
        {
            _context = new Mock<PortalContext>();
            _myEntityRepository = new Mock<IMyEntityRepository>();
            _uow = new Mock<IUnitOfWork>();
            _myEntityAppService = new Mock<IMyEntityAppService>();
        }

        [Fact]
        public void Create_Return_Success()
        {

            // Arrange
            var myEntity = new MyEntityCreateViewModel
            {
                Name = "fulano",
                Age = 18
            };

            var dbSetMock = new Mock<DbSet<MyEntity>>();
            _context.Setup(x => x.Set<MyEntity>()).Returns(dbSetMock.Object);
            _myEntityRepository.Setup(x => x.Add(new MyEntity(myEntity.Name, myEntity.Age)));
            _uow.Setup(x => x.MyEntities).Returns(_myEntityRepository.Object);
            _myEntityAppService.Setup(x => x.Add(myEntity)).Returns(new MyEntityViewModel {Name = myEntity.Name,Age = myEntity.Age });


            // Act
            var result = _myEntityAppService.Object.Add(myEntity);

            // Assert
            Assert.NotNull(result);
        }


    }
}
