using System;

//Dado estruturas que possuem as mesmas propriedades, mas cada objeto possui
//estados e tipos diferentes, esse design é aplicável
//É geralmente considerada como uma factory de outras factorys

//Sera criado um builder para cada tipo possivel com base no plano de celular
//e com base nas propriedades diferentes para cada plano
//“Mobile  plan | Text message limit  |     Mobile data transfer | Connection speed
//Prepaid       | 1,000/month         |     10 gigabytes/month   | 10 megabytes/sec
//Postpaid      | Unlimited           |     Unlimited            | 500 megabytes/sec”

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilePlanPrePaid = new MobilePlanClient(Enums.MobilePlan.Prepaid);
            Console.WriteLine(mobilePlanPrePaid.Describe()); 

            var mobilePlanPostPaid = new MobilePlanClient(Enums.MobilePlan.Postpaid);
            Console.WriteLine(mobilePlanPostPaid.Describe());

            Console.ReadLine();
        }
    }
}
