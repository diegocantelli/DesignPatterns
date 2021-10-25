using DesignPatterns.FactoryMethod.ConcreteCreator;
using DesignPatterns.FactoryMethod.AbstractCreator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.SimpleFactory
{
    public class SimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;

            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    pizzaria = null;
                    break;
            }

            return pizzaria;
        }
    }
}
