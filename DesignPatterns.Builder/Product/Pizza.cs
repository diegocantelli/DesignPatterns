using DesignPatterns.Builder.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Product
{
    public class Pizza
    {
        public TipoMassa TipoMassa { get; set; }
        public TipoBorda TipoBorda { get; set; }
        public Tamanho Tamanho { get; set; }
        public List<string> Ingredientes { get; set; } = new List<string>();

        public void PizzaConteudo()
        {
            Console.WriteLine($"Tipo da massa: {TipoMassa}");
            Console.WriteLine($"Tipo da borda: {TipoBorda}");
        }
    }
}
