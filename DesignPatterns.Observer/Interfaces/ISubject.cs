using System;
namespace DesignPatterns.Observer.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer)
        void Notify();

    }
}
