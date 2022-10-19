using System;
using DesignPatterns.Models;

namespace DesignPatterns.State
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public Finalizado()
        {
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado.");
        }
    }
}
