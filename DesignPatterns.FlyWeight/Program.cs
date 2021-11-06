using DesignPatterns.FlyWeight.ConcreteFlyweight;
using DesignPatterns.FlyWeight.FlyWeightFactory;
using System;

namespace DesignPatterns.FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usado para criar muitos objetos pequenos relacionados sem invocar muito trabalho de sobrecarga, melhorando
            // assim o desempenho e a capacidade de manutenção
            // Permite que o programa suporte grandes quantidades de objetos, mantendo baixo o consumo de memória

            // Um objeto FlyWeight possui duas partes:
            // Estado intrínseco: que é constante e é armazenado no próprio objeto flyweight na memória
            // Estado extrínseco: não é constante e precisa ser calculado em tempo de execução e não é armazenado
            // na memória
            Console.WriteLine("FlyWeight!");
            Console.WriteLine();
            Console.WriteLine("Círculos amarelos");

            for (int i = 0; i < 3; i++)
            {
                // Caso não exista um objeto do tipo círculo no dicionário, GetForma irá criá-lo e devolver uma instância que implementa IForma
                var forma = (Circulo)FormaFactory.GetForma("circulo");
                forma.SetCor("Amarelo " + i.ToString());
                forma.Desenhar();
            }


            Console.WriteLine("Círculos vermelhos");

            for (int i = 0; i < 3; i++)
            {
                // Caso não exista um objeto do tipo círculo no dicionário, GetForma irá criá-lo e devolver uma instância que implementa IForma
                var forma = (Circulo)FormaFactory.GetForma("circulo");
                forma.SetCor("Vermelho " + i.ToString());
                forma.Desenhar();
            }

        }
    }
}
