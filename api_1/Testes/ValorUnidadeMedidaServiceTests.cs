using NUnit.Framework;
using Servicos;

namespace Tests
{
    public class ValorUnidadeMedidaServiceTests
    {
        private IValorUnidadeMedidaService valorUnidadeMedidaService;

        [SetUp]
        public void Setup()
        {
            valorUnidadeMedidaService = new ValorUnidadeMedidaService();
        }

        [Test]
        public void DeveRetornarValorMetroQuadrado()
        {
            var valor = valorUnidadeMedidaService.ObterValorUnidadeMedida(UnidadeMedida.Metro);
            Assert.AreEqual(100m, valor);
        }
    }
}