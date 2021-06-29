using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Repositorios
{
    public class ValorUnidadeMedidaRepository : IValorUnidadeMedidaRepository
    {
        private static List<ValorUnidadeMedida> unidades;

        public ValorUnidadeMedidaRepository()
        {
            unidades = new List<ValorUnidadeMedida>
            {
                new ValorUnidadeMedida(UnidadeMedida.Metro, 100m),
                new ValorUnidadeMedida(UnidadeMedida.Pe, 52m),
            };
        }

        public decimal ObterValor(UnidadeMedida unidadeMedida)
        {
            return unidades.FirstOrDefault(x => x.UnidadeMedida == unidadeMedida).Valor;
        }
    }
}