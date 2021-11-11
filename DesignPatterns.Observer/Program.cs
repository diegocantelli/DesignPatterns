using System;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define uma dependência um-para-muitos entre objetos, para que quendo um objeto mudar de estado, todos os 
            // seus dependentes sejam notificados e atualizados automaticamente

            // Subject: São objetos publicadores (publishers). Quando ocorre alguma mudança no estado de um Subject, ele deve
            // notificar a todos os seus subscribers

            // Observers: Eles são assinantes (subscribers). Eles simplesmente recebem notificações sobre as mudanças de 
            // estado dos subjects

            ConcreteSubject Iphone = new ConcreteSubject("Iphone", 1000, "Disponível");

            ConcreteObserver cliente1 = new ConcreteObserver("cliente 1", Iphone);
            ConcreteObserver cliente2 = new ConcreteObserver("cliente 2", Iphone);
            ConcreteObserver cliente3 = new ConcreteObserver("cliente 3", Iphone);

            Iphone.SetDisponibilidade("Disponível");
        }
    }
}
