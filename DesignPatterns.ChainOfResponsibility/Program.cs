using System;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadoraDeDescontos = new CalculadorDeDescontos();

            var orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("Caneta",500));
            orcamento.AdicionaItem(new Item("Lapis",500));

            double desconto = calculadoraDeDescontos.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadLine();
        }
    }
}
