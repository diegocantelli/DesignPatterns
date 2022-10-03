using System;

//Dado estruturas que possuem as mesmas propriedades, mas cada objeto possui
//estados e tipos diferentes, esse design é aplicável

//Sera criado um builder para cada tipo possivel com base no plano de celular
//“Mobile  plan | Text message limit  |     Mobile data transfer | Connection speed
//Prepaid       | 1,000/month         |     10 gigabytes/month   | 10 megabytes/sec
//Postpaid      | Unlimited           |     Unlimited            | 500 megabytes/sec”

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
