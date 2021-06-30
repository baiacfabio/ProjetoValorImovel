using Modelos;
using Repositorios;

namespace Servicos
{
    public class ValorUnidadeMedidaService : IValorUnidadeMedidaService
    {
        private readonly IValorUnidadeMedidaRepository valorUnidadeMedidaRepository;

        public ValorUnidadeMedidaService(IValorUnidadeMedidaRepository valorUnidadeMedidaRepository)
        {
            this.valorUnidadeMedidaRepository = valorUnidadeMedidaRepository;
        }

        public decimal ObterValorUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            return valorUnidadeMedidaRepository.ObterValor(unidadeMedida);
        }
    }
}