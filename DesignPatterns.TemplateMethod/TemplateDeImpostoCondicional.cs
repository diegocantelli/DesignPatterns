using System;
using DesignPatterns.Models;

namespace DesignPatterns.TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional
    {
        // Este será o template method que será utilizado por cada classe que herdar
        // desssa classe abstrata.
        // É necessário que todas as classes possuam a mesma lógica por trás: Possuir uma taxacao minima e maxima
        // de acordo com alguns critérios
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        // estes são os métodos específicos que as classes deverão implementar
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
