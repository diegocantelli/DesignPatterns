using System;
using DesignPatterns.Models;

namespace DesignPatterns.State
{
    public interface EstadoDeUmOrcamento
    {
        // aplica-se um determinado desconto de acordo com o estado de um orcamento
        // aprovado, finalizado, recusado e etc
        void AplicaDescontoExtra(Orcamento orcamento);

        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
