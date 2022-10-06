using System;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Concrete
{
    public class PostPaidMobilePlan : IMobilePlan
    {
        public PostPaidMobilePlan()
        {
        }

        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PostPaidIntegration() { }
    }
}
