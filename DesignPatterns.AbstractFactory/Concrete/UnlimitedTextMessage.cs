using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class UnlimitedTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "Unlimited Text Message";
        public string QuantityPerMonth { get; set; } = "Unlimited"; 
    }
}
