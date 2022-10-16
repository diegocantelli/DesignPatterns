using System;
using DesignPatterns.ChainOfResponsibility.Interface;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        //Irá armazenar uma referencia para a proxima regra de desconto
        // No momento de instanciação dessa classe, deverá ser informada a proxima regra de desconto
        // a ser aplicada
        public Desconto Proximo { get; set; }

        public DescontoPorMaisDeQuinhentosReais()
        {
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            // Faz a chamada para a próxima regra de desconto
            return Proximo.Desconta(orcamento);
        }
    }
}
