using DesignPatterns.FactoryMethod.ConcreteProduct;
using DesignPatterns.FactoryMethod.AbstractCreator;
using DesignPatterns.FactoryMethod.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.ConcreteCreator
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) return new PizzaMussarelaSP();
            if (tipo.Equals("C")) return new PizzaCalabresaSP();

            return null;
        }
    }
}
