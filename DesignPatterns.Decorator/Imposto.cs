using System;
using DesignPatterns.Models;

namespace DesignPatterns.Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; private set; }

        // Recebe e armazena a referência para o próximo imposto que deverá
        // ser aplicado na sequência
        public Imposto(Imposto imposto)
        {
            OutroImposto = imposto;
        }

        // Construtor necessário para permitir que não seja obrigatório informar
        // um imposto no construtor de um outro imposto
        public Imposto()
        {
            OutroImposto = null;
        }

        // Cada classe que herda de imposto deverá implementar sua própria regra
        // de cálculo de imposto
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoProximoImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
