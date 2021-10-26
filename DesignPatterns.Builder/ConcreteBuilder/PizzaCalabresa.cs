using DesignPatterns.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.ConcreteBuilder
{
    public sealed class PizzaCalabresa : PizzaBuilder
    {
        public override void IncluiIngredientes()
        {
            pizza.TipoMassa = Enuns.TipoMassa.Fina;
            pizza.TipoBorda = Enuns.TipoBorda.Tradicional;
            pizza.Tamanho = Enuns.Tamanho.Grande;
        }

        public override void PrepararMassa()
        {
            pizza.Ingredientes.Add("Calabresa");
            pizza.Ingredientes.Add("Cebola");
            pizza.Ingredientes.Add("Azeitona");
        }
    }
}
