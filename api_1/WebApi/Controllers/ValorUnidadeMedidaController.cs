using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValorUnidadeMedidaController : ControllerBase
    {
        [HttpGet("{unidadeMedida}")]
        public ActionResult<decimal> Get(UnidadeMedida unidadeMedida)
        {
            return 100m;
        }
    }

    public enum UnidadeMedida
    {
        Metro = 1,
        Pe = 2
    }
}
