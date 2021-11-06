using DesignPatterns.Decorator.Component;
using DesignPatterns.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteDecorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            return base.Opcionais() + " - Com borda recheada";
        }

        public override decimal Preco()
        {
            // Soma-se 5 ao valor da pizza caso tenha a borda recheada
            return base.Preco() + 5;
        }
    }
}
