using System;
namespace DesignPatterns.Observer.Interfaces
{
    public interface IObserver
    {
        //ação que o observador deverá executar assim que o Subject notificar aos
        // observadores que algo mudou
        void Update(object obj);
    }
}
