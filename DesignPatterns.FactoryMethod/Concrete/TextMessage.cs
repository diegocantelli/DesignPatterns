using System;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Concrete
{
    public class TextMessage : ITextMessage
    {
        public TextMessage()
        {
        }

        public string Name { get; set; }
        public int QuantityPerMonth { get; set; }
    }
}
