using System;
using DesignPatterns.Models;

namespace DesignPatterns.TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV()
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue500(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue500(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 500) return true;
            }

            return false;
        }
    }
}
