using DesignPatterns.Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.RealSubject
{
    // RealSubject
    // Objeto que queremos usar de forma mais eficiente usando a classe proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            Console.WriteLine("Operação de leitura e escrita na pasta compartilhada");
        }
    }
}
