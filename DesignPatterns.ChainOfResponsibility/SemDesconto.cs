using System;
using DesignPatterns.ChainOfResponsibility.Interface;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility
{
    public class SemDesconto : Desconto
    {
        public SemDesconto()
        {
        }

        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
