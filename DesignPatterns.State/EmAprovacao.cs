using System;
using DesignPatterns.Models;

namespace DesignPatterns.State
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public EmAprovacao()
        {
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoDeUmOrcamento = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ser finalizado diretamente");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoDeUmOrcamento = new Reprovado();
        }
    }
}
