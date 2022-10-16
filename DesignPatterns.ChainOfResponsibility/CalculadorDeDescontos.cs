using System;
using System.Linq;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>
    /// Classe responsável por realizar a orquestração entre as regras de desconto
    /// </summary>
    public class CalculadorDeDescontos
    {
        public CalculadorDeDescontos()
        {
        }

        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorMaisDeQuinhentosReais();
            var d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
