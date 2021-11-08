using DesignPatterns.Mediator.Colleague;
using DesignPatterns.Mediator.ConcreteColleague;
using DesignPatterns.Mediator.ConcreteMediator;
using DesignPatterns.Mediator.Mediator;
using System;

namespace DesignPatterns.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mediator: Promove o acoplamento fraco, evitando que os objetos se refiram explicatamente uns aos outros, além 
            // de permitir que você varie sua interação de forma independente

            // O mediator atua como um centralizador/roteador
            IFacebookGroupMediator facebookGroupMediator = new ConcreteFacebookMediator();

            // Cada instância de usuário guarda uma referência para o mediator, que é repassada para a classe abstrata
            User macoratti = new ConcreteUser(facebookGroupMediator, "Macoratti");
            User miriam = new ConcreteUser(facebookGroupMediator, "Miriam");
            User jessica = new ConcreteUser(facebookGroupMediator, "Jessica");
            User yuri = new ConcreteUser(facebookGroupMediator, "Yuri");

            // Register User guarda uma lista de usuários 'cadastrados' no mediator
            facebookGroupMediator.RegisterUser(macoratti);
            facebookGroupMediator.RegisterUser(miriam);
            facebookGroupMediator.RegisterUser(jessica);
            facebookGroupMediator.RegisterUser(yuri);

            // Send -> Chama a instância concreta do mediator. Através do loop da lista de usuários cadastrados no mediator
            // são enviadas as mensagens para cada usuário cadastrado
            macoratti.Send("Mensagem enviada por Macoratti");
            yuri.Send("Onde posso encontrar os vídeos?");
            macoratti.Send("Veja a playlist 'Design Patterns'");

            Console.ReadKey();
        }
    }
}
