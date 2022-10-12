using System;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands
{
    public class CreditCardPaymentCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public CreditCardPaymentCommand(Purchase purchase)
        {
            _purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Integração com cartão de crédito.");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Ocorreu um problema na operação");
        }
    }
}
