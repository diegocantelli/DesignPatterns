using System;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Concrete
{
    public class ConnectionSpeed : IConnectionSpeed
    {
        public ConnectionSpeed()
        {
        }

        public string Name { get; set; }
        public int Velocity { get; set; }
    }
}
