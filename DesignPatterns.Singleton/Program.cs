using DesignPatterns.Singleton.MultiThread;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Program
    {
        //Singleton: garante que uma classe tenha somente uma instância fornecendo um ponto de acesso global a essa instância
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Thread1(),
                () => Thread2()
            );

            Console.ReadLine();
        }

        private static void Thread1()
        {
            Console.WriteLine("Criando a Thread 1");
            var singleton = SingletonMultiThread.Instance;
        }

        private static void Thread2()
        {
            Console.WriteLine("Criando a Thread 2");
            var singleton = SingletonMultiThread.Instance;
        }
    }
}
