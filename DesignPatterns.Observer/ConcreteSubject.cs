using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string Produto;
        private decimal Preco;
        private string Disponibilidade;

        public ConcreteSubject(string produto, int preco, string status)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = status;
        }

        public string GetDisponibilidade()
        {
            return Disponibilidade;
        }

        public void SetDisponibilidade(string status)
        {
            Disponibilidade = status;
            Console.WriteLine("A disponibilidade mudou de sem estoque para 'Disponível'");
            NotificarObserver();
        }

        public void NotificarObserver()
        {
            Console.WriteLine("Notificando todo os inscritos nesta oferta");
            foreach (var observer in observers)
            {
                observer.Atualiza(Disponibilidade);
            }
        }

        public void RegistrarObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
