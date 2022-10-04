using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class TenGigaByte : IMobileDataFactory
    {
        public TenGigaByte()
        {
        }

        public string Name { get; set; } = "10 Gb/Sec";
        public string Limit { get; set; } = "10 Gb/Sec";

    }
}
