using System;
namespace DesignPatterns.Command.Interfaces
{
    //classe que define o contrato do comando para a operacao Purchase
    public interface IPurchaseCommand
    {
        void ExecuteOperation();
        void RevertOperation();
    }
}
