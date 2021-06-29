﻿namespace Modelos
{
    public class ValorUnidadeMedida
    {
        public decimal Valor { get; private set; }
        public UnidadeMedida UnidadeMedida { get; private set; }

        public ValorUnidadeMedida(UnidadeMedida unidadeMedida, decimal valor)
        {
            UnidadeMedida = unidadeMedida;
            Valor = valor;
        }
    }

    public enum UnidadeMedida
    {
        Metro = 1,
        Pe = 2
    }
}
