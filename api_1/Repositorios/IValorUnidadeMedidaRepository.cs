using Modelos;

namespace Repositorios
{
    public interface IValorUnidadeMedidaRepository
    {
        decimal ObterValor(UnidadeMedida unidadeMedida);
    }
}