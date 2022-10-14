using System;
using System.Collections.Generic;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Models
{
    public class Blog : ISubject
    {
        private Post _post = new Post();
        private List<IObserver> _observers = new List<IObserver>();

        public Blog()
        {
        }

        // método subscribe
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        // método unsubscribe
        public void Dettach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_post);
            }
        }

        // A cada novo post adicionado, será chamado o método notify, responsável
        // por notificar a todos os interessados
        public void AddPost(Post post)
        {
            _post = post;
            Notify();
        }
    }
}
