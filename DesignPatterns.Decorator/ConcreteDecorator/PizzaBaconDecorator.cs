using DesignPatterns.Decorator.Component;
using DesignPatterns.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteDecorator
{
    public class PizzaBaconDecorator : PizzaDecorator
    {
        public PizzaBaconDecorator(IPizza pizza) : base(pizza) { }

        public override string Opcionais()
        {
            return base.Opcionais() + " - Adicionado Bacon à pizza";
        }

        public override decimal Preco()
        {
            // Adicionado 10 reais ao valor da pizza quando for de bacon
            return base.Preco() + 10.00M;
        }
    }
}
