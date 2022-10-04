using System;
using DesignPatterns.AbstractFactory.Concrete;
using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    public class MobilePlanClient
    {
        private IMobilePlanFactory _mobilePlanFactory;

        public MobilePlanClient(MobilePlan mobilePlan)
        {
            if(mobilePlan == MobilePlan.Prepaid)
            {
                _mobilePlanFactory = new PrePaidFactory();
            }
            else
            {
                _mobilePlanFactory = new PostPaidFactory();
            }
        }

        public string Describe()
        {
            return $"Mobile plan: {_mobilePlanFactory.CreateMobileData().Name}" +
            $"Text Message: {_mobilePlanFactory.CreateTextMessage().Name}" +
            $"Internet Connection: {_mobilePlanFactory.CreateConnectionSpeed().Name}";
        }
    }
}
