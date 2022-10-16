using System;
using System.Linq;
using DesignPatterns.ChainOfResponsibility.Interface;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DescontoPorCincoItens : Desconto
    {
        //Irá armazenar uma referencia para a proxima regra de desconto
        // No momento de instanciação dessa classe, deverá ser informada a proxima regra de desconto
        // a ser aplicada
        public Desconto Proximo { get; set; }

        public DescontoPorCincoItens()
        {
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count() > 5)
            {
                return orcamento.Valor * 0.1;
            }

            // Faz a chamada para a próxima regra de desconto
            return Proximo.Desconta(orcamento);
        }
    }
}
