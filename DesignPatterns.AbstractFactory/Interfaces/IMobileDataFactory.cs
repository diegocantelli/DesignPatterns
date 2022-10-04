using System;
namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IMobileDataFactory
    {
        string Name { get; set; }
        string Limit { get; set; }
    }
}
