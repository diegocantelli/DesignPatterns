using System;

namespace DesignPatterns.Command.Receiver
{
    // receiver: classe que sabe de fato como implementar as operações
    public class Chef
    {
        public void PreparandoPrato()
        {
            Console.WriteLine("Chefe está preparando o prato.");
        }

        public void PreparandoSobremesa()
        {
            Console.WriteLine("Chefe está preparando a sobremesa");
        }
    }
}
