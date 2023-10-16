// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using Moq;

using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;
using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;
using PortalComprasPub.Infrastructure.Data.Repositories;

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
            _myEntityRepository = new Mock<IMyEntityRepository>(new MyEntityRepository(_context.Object));
            _uow = new Mock<IUnitOfWork>(_myEntityRepository.Object);
            _myEntityAppService = new Mock<IMyEntityAppService>(_uow.Object);
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

            // Act
            var result = _myEntityAppService.Object.Add(myEntity);

            // Assert
            Assert.NotNull(result);
        }


    }
}
