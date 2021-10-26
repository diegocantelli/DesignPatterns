using DesignPatterns.Builder.Builder;
using DesignPatterns.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuilder _builder;

        public Pizzaria(PizzaBuilder builder)
        {
            _builder = builder;
        }

        public void MontaPizza()
        {
            _builder.CriarPizza();
            _builder.PrepararMassa();
            _builder.IncluiIngredientes();
        }

        public Pizza GetPizza()
        {
            return _builder.GetPizza();
        }
    }
}
