using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public interface ICalculadora
    {
        ICareTaker backupUltimoCalculo();

        void RestauraUltimoCalculo(ICareTaker memento);

        int GetCalculoResultado();
        void SetPrimeiroNumero(int num1);
        void SetSegundoNumero(int num2);
    }
}
