using System;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command
{
    public class PurchaseLogic
    {
        private readonly IPurchaseCommand _purchaseCommand;

        public PurchaseLogic(IPurchaseCommand purchaseCommand)
        {
            _purchaseCommand = _purchaseCommand;
        }

        public void ConfirmPurchase()
        {
            try
            {
                _purchaseCommand.ExecuteOperation();
            }
            catch (Exception ex)
            {
                _purchaseCommand.RevertOperation();
            }
        }
    }
}
