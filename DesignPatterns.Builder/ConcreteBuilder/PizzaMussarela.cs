using DesignPatterns.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public override void IncluiIngredientes()
        {
            pizza.TipoMassa = Enuns.TipoMassa.Grossa;
            pizza.TipoBorda = Enuns.TipoBorda.Recheada;
            pizza.Tamanho = Enuns.Tamanho.Grande;
        }

        public override void PrepararMassa()
        {
            pizza.Ingredientes.Add("Mussarela");
            pizza.Ingredientes.Add("Tomate");
            pizza.Ingredientes.Add("Azeitona");
        }
    }
}
