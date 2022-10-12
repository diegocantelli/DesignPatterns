using System;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands
{
    public class StorageManagerCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public StorageManagerCommand(Purchase purchase)
        {
            _purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Operacao de atualizacao de estoque.");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Ocorreu um problema na operação de atualizado de estoque");
        }
    }
}
