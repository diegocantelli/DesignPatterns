using DesignPatterns.Builder.ConcreteBuilder;
using DesignPatterns.Builder.Director;
using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builder: Tem como objetivo separar a construção de um objeto complexo da sua representação
            // de modo que o processo de construção possa criar diferentes representações
            //  - Product: representa o tipo de objeto complexo a ser criado pelo Builder, inclui classes que definem
            //      as partes constituintes, incluindo interfaces para montar as partes no resultado final.
            //  - Builder: Define uma interface/classe abstrata para criar partes de um objeto Product; Define todos os passos
            //      que devem ser executados para criar um Product
            //  - ConcreteBuilder: Constrói e monta partes do produto implementando a interface Builder, define e acompanha
            //      a representação criada e fornece uma interface para retornar o produto
            //  - Director: Constrói um objeto usando a interface Builder. Controla o algoritmo que gera o objeto do produto Final.


            // PizzaCalabresa herda de PizzaBuilder
            var pizzaria = new Pizzaria(new PizzaCalabresa());
            pizzaria.MontaPizza();

            // Chama o método GetPizza da classe PizzaBuilder, que retorna uma referência da pizza de calabresa
            // retorna uma instância de pizza de calabresa já 'montada'
            var pizza = pizzaria.GetPizza();
            pizza.PizzaConteudo();

            Console.ReadKey();
        }
    }
}
