namespace Servicos
{
    public class ValorUnidadeMedidaService : IValorUnidadeMedidaService
    {
        public decimal ObterValorUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            return 100m;
        }
    }

    public interface IValorUnidadeMedidaService
    {
        decimal ObterValorUnidadeMedida(UnidadeMedida unidadeMedida);
    }

    public enum UnidadeMedida
    {
        Metro = 1,
        Pe = 2
    }
}
