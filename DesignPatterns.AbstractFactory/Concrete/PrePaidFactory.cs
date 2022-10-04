using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class PrePaidFactory : IMobilePlanFactory
    {
        public PrePaidFactory()
        {
        }


        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new LowSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new TenGigaByte();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new ThousandTextMessage();
        }
    }
}
