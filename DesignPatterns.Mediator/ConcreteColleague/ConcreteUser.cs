using DesignPatterns.Mediator.Colleague;
using DesignPatterns.Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.ConcreteColleague
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string nome) : base(mediator, nome)
        {

        }
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} : recebida <= {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} : enviada => {message}");
            mediator.SendMessage(message, this);
        }
    }
}
