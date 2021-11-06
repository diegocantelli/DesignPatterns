using DesignPatterns.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string Opcionais()
        {
            return _pizza.Opcionais();
        }

        public virtual decimal Preco()
        {
            return _pizza.Preco();
        }
    }
}
