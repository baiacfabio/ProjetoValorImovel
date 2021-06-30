using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CalculaValorImovelController : ControllerBase
    {
        const string URL_BASE = "https://fabio-webapi-1.herokuapp.com/api/v1/";
        const int VALOR_MINIMO = 10;
        const int VALOR_MAXIMO = 10_000;

        [HttpGet("{quantificadorMedida}")]
        public async Task<IActionResult> CalcularValorAsync([FromRoute] decimal quantificadorMedida)
        {
            if (quantificadorMedida < VALOR_MINIMO || quantificadorMedida > VALOR_MAXIMO)
                return new BadRequestObjectResult($"Quantificador da medida deve ser um valor entre {VALOR_MINIMO} e {VALOR_MAXIMO}");

            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(URL_BASE)
            };

            HttpResponseMessage resposta = await httpClient.GetAsync("ValorUnidadeMedida/Metro");

            resposta.EnsureSuccessStatusCode();

            var valor = await resposta.Content.ReadAsAsync<decimal>();

            var total = quantificadorMedida * valor;
            return Ok(total);
        }
    }
}