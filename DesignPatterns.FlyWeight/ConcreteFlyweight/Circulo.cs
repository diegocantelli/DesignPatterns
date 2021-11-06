using DesignPatterns.FlyWeight.FlyWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight.ConcreteFlyweight
{
    public class Circulo : IForma
    {
        //  Extrínseco
        public string Cor { get; private set; }

        // Intrínseco
        private int x = 10;
        private int y = 20;
        private int raio = 30;

        public void SetCor(string cor)
        {
            Cor = cor;
        }
        public void Desenhar()
        {
            Console.WriteLine($"Círculo desenhado: Cor:{Cor}, x: {x}, y:{y}, z:{raio}");
        }
    }
}
