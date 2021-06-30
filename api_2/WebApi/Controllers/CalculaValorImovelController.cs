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
        const int METRAGEM_MINIMA = 10;
        const int METRAGEM_MAXIMA = 10_000;

        [HttpGet("{metragem}")]
        public async Task<IActionResult> CalcularValorPelaMetragemAsync([FromRoute] decimal metragem)
        {
            if (metragem < METRAGEM_MINIMA || metragem > METRAGEM_MAXIMA)
                return new BadRequestObjectResult($"A metragem informada deve ser um valor entre {METRAGEM_MINIMA} e {METRAGEM_MAXIMA}");

            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(URL_BASE)
            };

            HttpResponseMessage resposta = await httpClient.GetAsync("ValorUnidadeMedida/Metro");

            resposta.EnsureSuccessStatusCode();

            var valor = await resposta.Content.ReadAsAsync<decimal>();

            var total = metragem * valor;
            return Ok(total);
        }
    }
}