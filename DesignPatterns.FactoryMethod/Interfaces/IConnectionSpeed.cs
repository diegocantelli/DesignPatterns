using System;
namespace DesignPatterns.FactoryMethod.Interfaces
{
    public interface IConnectionSpeed
    {
        string Name { get; set; }
        int Velocity { get; set; }
    }
}
