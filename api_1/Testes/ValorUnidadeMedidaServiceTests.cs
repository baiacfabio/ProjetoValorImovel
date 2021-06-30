using Modelos;
using NSubstitute;
using NUnit.Framework;
using Repositorios;
using Servicos;

namespace Tests
{
    public class ValorUnidadeMedidaServiceTests
    {
        private IValorUnidadeMedidaService valorUnidadeMedidaService;
        private IValorUnidadeMedidaRepository valorUnidadeMedidaRepository;

        [SetUp]
        public void Setup()
        {
            valorUnidadeMedidaRepository = Substitute.For<IValorUnidadeMedidaRepository>();
            valorUnidadeMedidaRepository.ObterValor(Arg.Any<UnidadeMedida>()).Returns(100);

            valorUnidadeMedidaService = new ValorUnidadeMedidaService(valorUnidadeMedidaRepository);
        }

        [Test]
        public void DeveRetornarValorMetroQuadrado()
        {
            var valor = valorUnidadeMedidaService.ObterValorUnidadeMedida(UnidadeMedida.Metro);
            Assert.AreEqual(100m, valor);
        }
    }
}