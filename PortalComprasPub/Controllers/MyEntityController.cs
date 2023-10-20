// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using Microsoft.AspNetCore.Mvc;

using PortalComprasPub.Application.Interfaces;
using PortalComprasPub.Application.ViewModels.MyEntityViewModel;

namespace PortalComprasPub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyEntityController : Controller
    {
        private readonly IMyEntityAppService _myEntityApplicationService;
        public MyEntityController(IMyEntityAppService myEntityAppService)
        {
            _myEntityApplicationService = myEntityAppService;
        }


        [HttpPost]
        public IActionResult Create([FromBody] MyEntityCreateViewModel createMyEntityViewModel)
        {

            var myEntity = _myEntityApplicationService.Add(createMyEntityViewModel);

            if (myEntity is null)
                return BadRequest(new
                {
                    success = false
                });

            return Created("", myEntity);

        }
    }
}
