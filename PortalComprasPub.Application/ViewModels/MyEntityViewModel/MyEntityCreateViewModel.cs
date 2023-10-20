// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using FluentValidation;

namespace PortalComprasPub.Application.ViewModels.MyEntityViewModel
{
    public class MyEntityCreateViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class MyEntityCreateViewModelValidation : AbstractValidator<MyEntityCreateViewModel>
    {
        public MyEntityCreateViewModelValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Age).GreaterThan(0);
        }
    }
}
