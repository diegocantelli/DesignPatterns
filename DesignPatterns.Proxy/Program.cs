using DesignPatterns.Proxy.Proxy;
using System;

namespace DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fornece um objeto que atua como um substituto para um objeto de serviço real usado por um cliente para controlar
            // o acesso a ele
            // Permite encapsular a instância de uma classe complexa usando uma instância de outra classe que possui a 
            // mesma interface
            Console.WriteLine("Exemplo de implementação do padrão Proxy!");
            Console.WriteLine();

            Funcionario func1 = new Funcionario("func1", "132", "CEO");
            var pastaCompartilhadaProxy = new PastaCompartilhadaProxy(func1);
            pastaCompartilhadaProxy.OperacaoDeLeituraGravacao();

            Console.WriteLine();

            Funcionario func2 = new Funcionario("func2", "132", "TI");
            var pastaCompartilhadaProxy2 = new PastaCompartilhadaProxy(func2);
            pastaCompartilhadaProxy2.OperacaoDeLeituraGravacao();
        }
    }
}
