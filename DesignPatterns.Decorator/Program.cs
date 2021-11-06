using DesignPatterns.Decorator.Component;
using DesignPatterns.Decorator.ConcreteComponent;
using DesignPatterns.Decorator.ConcreteDecorator;
using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atribui responsabilidades a um objeto de forma dinâmica sem afetar o comportamento de outros objetos
            // da mesma classe

            IPizza pizza = new PizzaBase();
            Console.WriteLine($"Preço da pizza: {pizza.Preco()}");
            Console.WriteLine($"Opcionais: {pizza.Opcionais()}");
            Console.WriteLine();
            Console.WriteLine("Tecle algo para adicionar alguns adicionais à pizza.");
            Console.ReadKey();

            IPizza bordaRecheada = new BordaRecheadaDecorator(pizza);
            IPizza bacon = new PizzaBaconDecorator(bordaRecheada);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Ingredientes Opcionais escolhidos: {bacon.Opcionais()}");
            Console.WriteLine($"Preço final da pizza com os ingredientes opcionais: {bacon.Preco()}");

            Console.ReadKey();
        }
    }
}
