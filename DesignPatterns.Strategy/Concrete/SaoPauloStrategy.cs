using System;
namespace DesignPatterns.Strategy.Concrete
{
    public class SaoPauloStrategy : ICityStrategy
    {
        public SaoPauloStrategy()
        {
        }

        public void ApplyEmploymentRule()
        {
            Console.WriteLine("Necessário empregados permanentes");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.15m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.10m;
        }
    }
}
