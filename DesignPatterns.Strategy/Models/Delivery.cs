using System;
namespace DesignPatterns.Strategy.Models
{
    public class Delivery
    {
        private readonly ICityStrategy _cityStrategy;

        public Delivery(ICityStrategy cityStrategy)
        {
            _cityStrategy = cityStrategy;
        }

        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Tax => _cityStrategy.ApplyTax(this.Price);
        public decimal Profit => _cityStrategy.ApplyProfit(this.Price);
        public decimal Price { get; set; }
    }
}
