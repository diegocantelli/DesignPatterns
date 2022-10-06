using System;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Concrete
{
    public class PrePaidMobilePlan : IMobilePlan
    {
        public PrePaidMobilePlan()
        {
        }

        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PrePaidIntegration() { }
    }
}
