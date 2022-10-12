using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands
{
    // classe que encapsula a logica da execucao e reversao dos comandos a serem executados
    // Um 'orquestrador' de comandos simplificado
    public class TransactionPurchaseCommand : IPurchaseCommand
    {
        private readonly List<IPurchaseCommand> _purchaseCommands;
        private List<IPurchaseCommand> executedPurchaseCommands;
        private List<IPurchaseCommand> failedPurchaseCommands;

        public TransactionPurchaseCommand(List<IPurchaseCommand> purchaseCommands)
        {
            _purchaseCommands = purchaseCommands;
            executedPurchaseCommands = new List<IPurchaseCommand>();
            failedPurchaseCommands = new List<IPurchaseCommand>();
        }

        public void ExecuteOperation()
        {
            foreach (var purchaseCommand in _purchaseCommands)
            {
                try
                {
                    purchaseCommand.ExecuteOperation();
                    executedPurchaseCommands.Add(purchaseCommand);
                }
                catch (Exception ex)
                {
                    failedPurchaseCommands.Add(purchaseCommand);
                }
            }

            if(failedPurchaseCommands.Any())
            {
                RevertOperation();
            }
        }

        public void RevertOperation()
        {
            foreach(var purchasedCommand in executedPurchaseCommands)
            {
                purchasedCommand.RevertOperation();
            }
        }
    }
}
