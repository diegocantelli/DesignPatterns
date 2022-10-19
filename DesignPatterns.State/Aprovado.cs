using System;
using DesignPatterns.Models;

namespace DesignPatterns.State
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public Aprovado()
        {
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já aprovado anteriormente.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoDeUmOrcamento = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já aprovado nao pode ser reprovado");
        }
    }
}
