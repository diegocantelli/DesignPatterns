using System;
using DesignPatterns.Models;

namespace DesignPatterns.Decorator
{
    public class ISS  : Imposto
    {
        public ISS(Imposto imposto):base(imposto)
        {
        }

        public ISS() : base()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoProximoImposto(orcamento);
        }
    }
}
