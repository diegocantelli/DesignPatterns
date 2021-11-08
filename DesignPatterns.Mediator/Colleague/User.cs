using DesignPatterns.Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Colleague
{
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;

        public User(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void ReceiveMessage(string message);
    }
}
