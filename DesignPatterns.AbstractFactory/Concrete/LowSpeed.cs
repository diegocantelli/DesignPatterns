using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class LowSpeed : IConnectionSpeedFactory
    {
        public string Name { get; set; } = "Low Speed";
        public string Velocity { get; set; } = "50 mb/sec";
    }
}
