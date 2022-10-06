using System;
namespace DesignPatterns.FactoryMethod.Interfaces
{
    public interface ITextMessage
    {
        string Name { get; set; }
        int QuantityPerMonth { get; set; }
    }
}
