using System;
namespace DesignPatterns.Strategy.Concrete
{
    public class LosAngelesStrategy : ICityStrategy
    {
        public LosAngelesStrategy()
        {
        }

        public void ApplyEmploymentRule()
        {
            Console.WriteLine("Sem empregados permanentes");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.1m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.20m;
        }
    }
}
