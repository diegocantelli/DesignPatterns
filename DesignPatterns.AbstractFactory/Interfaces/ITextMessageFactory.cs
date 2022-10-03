using System;
namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface ITextMessageFactory
    {
        string Name { get; set; }
        string QuantityPerMonth { get; set; }
    }
}
