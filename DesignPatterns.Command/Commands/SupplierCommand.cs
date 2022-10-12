using System;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands
{
    public class SupplierCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public SupplierCommand(Purchase purchase)
        {
            _purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Integração com fornecedor.");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Ocorreu um problema na operação");
        }
    }
}
