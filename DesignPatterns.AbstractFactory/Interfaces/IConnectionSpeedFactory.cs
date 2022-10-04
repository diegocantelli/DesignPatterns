using System;
namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IConnectionSpeedFactory
    {
        string Name { get; set; }
        string Velocity { get; set; }
    }
}
