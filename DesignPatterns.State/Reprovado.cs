using System;
using DesignPatterns.Models;

namespace DesignPatterns.State
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public Reprovado()
        {
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos nao aprovados nao recebem desconto extra");
        }
    }
}
