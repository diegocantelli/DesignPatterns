using DesignPatterns.Mediator.Colleague;
using DesignPatterns.Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.ConcreteMediator
{
    public class ConcreteFacebookMediator : IFacebookGroupMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var u in userList)
            {
                if(u != user)
                {
                    u.ReceiveMessage(msg);
                }
            }
        }
    }
}
