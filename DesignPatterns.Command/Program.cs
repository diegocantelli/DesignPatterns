using DesignPatterns.Command.ConcreteCommand;
using DesignPatterns.Command.Invoker;
using DesignPatterns.Command.Receiver;
using System;

namespace DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsula uma requisição como um objeto, permitindo que clientes parametrizem diferentes requisições,
            // filas ou requisições de logs, com suporte a reverter as operações.

            Chef chef = new Chef();

            Pedido pedido = new Pedido(chef, "prato");
            Garcom garcom = new Garcom(pedido);
            garcom.Executar();

            Console.ReadKey();
        }
    }
}
