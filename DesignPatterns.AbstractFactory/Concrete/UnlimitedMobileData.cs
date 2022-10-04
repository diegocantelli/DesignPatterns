using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class UnlimitedMobileData : IMobileDataFactory
    {
        public UnlimitedMobileData()
        {
        }

        public string Name { get; set; } = "Unlimited";
        public string Limit { get; set; } = "Unlimited";
    }
}
