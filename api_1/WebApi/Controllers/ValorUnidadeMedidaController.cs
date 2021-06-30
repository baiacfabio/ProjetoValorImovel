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

        /// <summary>
        /// Retorna o valor definido para a unidade de medida informada
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     GET api/v1/ValorUnidadeMedida/{unidadeMedida}
        ///     100
        ///
        /// </remarks>
        /// <returns>Valor</returns>
        /// <response code="200">Retorna o valor da unidade de medida que foi solicitada por parametro</response>
        [HttpGet("{unidadeMedida}")]
        public ActionResult<decimal> Get(UnidadeMedida unidadeMedida)
        {
            return valorUnidadeMedidaService.ObterValorUnidadeMedida(unidadeMedida);
        }
    }
}
