using Microsoft.AspNetCore.Mvc;
using Modelos;
using Servicos;

namespace WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValorUnidadeMedidaController : ControllerBase
    {
        private readonly IValorUnidadeMedidaService valorUnidadeMedidaService;

        public ValorUnidadeMedidaController(IValorUnidadeMedidaService valorUnidadeMedidaService)
        {
            this.valorUnidadeMedidaService = valorUnidadeMedidaService;
        }

        [HttpGet("{unidadeMedida}")]
        public ActionResult<decimal> Get(UnidadeMedida unidadeMedida)
        {
            return valorUnidadeMedidaService.ObterValorUnidadeMedida(unidadeMedida);
        }
    }
}
