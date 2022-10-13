using System;
namespace DesignPatterns.Strategy
{
    public interface ICityStrategy
    {
        decimal ApplyTax(decimal price);
        void ApplyEmploymentRule();
        decimal ApplyProfit(decimal price);
    }
}
