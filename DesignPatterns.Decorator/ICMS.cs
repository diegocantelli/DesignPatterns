using System;
using DesignPatterns.Models;

namespace DesignPatterns.Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto imposto) : base(imposto)
        {
        }

        public ICMS() : base()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoProximoImposto(orcamento);
        }
    }
}
