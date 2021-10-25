using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.AbstractProduct
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        protected string Massa;
        protected string Molho;
        protected List<string> Ingredientes = new List<string>();

        public abstract void Preparar();
    }
}
