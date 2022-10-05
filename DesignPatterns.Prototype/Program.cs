using System;

namespace DesignPatterns.Prototype
{
    //Este padrao foca em copiar objetos de forma eficiente atraves da tecnica DeepCopy
    //Util quando se deseja criar multiplas instancias de um mesmo objeto, com um estado similar e apenas
    //deseja-se alterar algumas propriedades
    class Program
    {
        static void Main(string[] args)
        {
            var customerPlan = new CustomerPlan()
            {
                Name = "Plan version 1,",
                Price = 100,
                PlanVersion = new PlanVersion() { Version = 1 }
            };

            var customerPlanVersion2 = (CustomerPlan)customerPlan.DeepCopy();

            customerPlanVersion2.Price = 200;

            Console.WriteLine("Plan 1 " + customerPlan.Price);
            Console.WriteLine("Plan 2 " + customerPlanVersion2.Price);

            Console.ReadLine();
        }
    }
}
