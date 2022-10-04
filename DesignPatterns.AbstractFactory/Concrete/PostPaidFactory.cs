using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class PostPaidFactory : IMobilePlanFactory
    {
        public PostPaidFactory()
        {
        }

        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new HighSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new UnlimitedMobileData();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new UnlimitedTextMessage();
        }
    }
}
