using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }

        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistrarObserver(this);
        }
        public void Atualiza(string disponibilidade)
        {
            Console.WriteLine($"Olá { Usuario} o produto que você deseja está agora disponível em nosso site.");
        }
    }
}
