using DesignPatterns.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ConcreteComponent
{
    public class PizzaBase : IPizza
    {
        public string Opcionais()
        {
            var pizza = "Pizza normal ou padrão";
            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00;
            return Convert.ToDecimal(preco);
        }
    }
}
