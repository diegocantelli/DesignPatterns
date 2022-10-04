using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class HighSpeed : IConnectionSpeedFactory
    {
        public HighSpeed()
        {
        }

        public string Name { get; set; } = "High Speed";
        public string Velocity { get; set; } = "500 mb/sec";
    }
}
