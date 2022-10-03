using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class ThousandTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "A thousand text message";
        public string QuantityPerMonth { get; set; } = "1000";
    }
}
