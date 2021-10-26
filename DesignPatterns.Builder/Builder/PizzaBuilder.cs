using DesignPatterns.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public void CriarPizza()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }

        public abstract void PrepararMassa();
        public abstract void IncluiIngredientes();
    }
}
