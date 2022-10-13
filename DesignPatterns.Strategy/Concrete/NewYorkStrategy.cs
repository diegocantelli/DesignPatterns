using System;
namespace DesignPatterns.Strategy.Concrete
{
    public class NewYorkStrategy : ICityStrategy
    {
        public NewYorkStrategy()
        {
        }

        public void ApplyEmploymentRule()
        {
            Console.WriteLine("Sem empregados permanentes");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.25m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.10m;
        }
    }
}
