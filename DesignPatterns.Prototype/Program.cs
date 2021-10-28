using DesignPatterns.Prototype.ConcretePrototype;
using System;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proptotype: Especificar tipos de objetos a serem criados usando uma instância protótipo e criar novos
            // objetos pela cópia desse protótipo

            // Prototype: Declara uma interface para objetos capazes de clonarem a si mesmos
            // ConcretePrototype: Faz a implementação para um prototype(implementa uma operação para se clonar)
            // Client: Cria um novo objeto através de um prototype que é capaz de clonar a si mesmo.

            // Shallow Copy: Copia todo os tipos de referência ou tipos de valor, mas não copia os objetos aos quais as referências
            // se referem. As referências no novo objeto apontam para os mesmos objetos os quais no objeto original apontam

            // Deep copy: Copia todos os tipos de referência ou valor, mas ao contrário da shallow copy, os tipos de referência não
            // irão mais apontar para os mesmos os quais o objeto original apontam

            var soldado1 = new Soldado();
            soldado1.Nome = "Soldado 1";
            soldado1.Arma = "Pistola";
            soldado1.Acessorio = new Acessorio { Nome = "Colete"};

            var soldado2 = (Soldado)soldado1.Clone();
            soldado2.Nome = "Soldado 2";
            soldado2.Arma = "Fuzil";
            soldado2.Acessorio = new Acessorio { Nome = "Capacete" }; ;

            Console.WriteLine("");
            Console.WriteLine("Exibe valores do objeto original");
            Console.WriteLine($"Nome: {soldado1.Nome}");
            Console.WriteLine($"Nome acessorio: {soldado1.Acessorio.Nome}");

            Console.WriteLine("");
            Console.WriteLine("Exibe valores do objeto clonado");
            Console.WriteLine($"Nome: {soldado2.Nome}");
            Console.WriteLine($"Nome acessorio: {soldado2.Acessorio.Nome}");

            Console.ReadLine();
        }
    }
}
