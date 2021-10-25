using DesignPatterns.FactoryMethod.AbstractCreator;
using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            // Factory Method: Definir uma interface para criar objetos, mas permitir que as subclasses decidam qual classe
            // instanciar.
            // Permite que o cliente não precise saber quais tipos de objetos serão criados.
            // Usa a herança e depende de uma subclasse para tratar com a instanciação do objeto desejado.
            // Cria uma instância de várias classes derivadas.
            // Usado para criar objetos sem expor a lógica de criação ao cliente.s
            Console.WriteLine("===============Pizzaria=====================");
            Console.WriteLine("Informe o local: (S)São Paulo ou (R)Rio de Janeiro");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine(" ");
            Console.WriteLine("Informe a pizza escolhida: (M)Mussarela ou (C)Calabresa. ");
            var pizzaEscolhida = Console.ReadLine().ToUpper();


            PizzaFactoryMethod pizzaria = SimpleFactory.SimpleFactory.CriarPizzaria(localEscolhido);
            var pizza = pizzaria.MontaPizza(pizzaEscolhida);
            pizza.Preparar();

            Console.ReadLine();
        }
    }
}
