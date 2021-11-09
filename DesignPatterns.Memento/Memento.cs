using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Memento : ICareTaker, IRestoreCalculus
    {
        private readonly int primeiroNumero;
        private readonly int segundoNumero;

        public Memento(int numero1, int numero2)
        {
            primeiroNumero = numero1;
            segundoNumero = numero2;
        }
        public int GetPrimeiroNumero()
        {
            return primeiroNumero;
        }

        public int GetSegundoNumero()
        {
            return segundoNumero;
        }
    }
}
