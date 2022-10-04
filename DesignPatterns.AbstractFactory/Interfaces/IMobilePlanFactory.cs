using System;
namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IMobilePlanFactory
    {
        ITextMessageFactory CreateTextMessage();
        IConnectionSpeedFactory CreateConnectionSpeed();
        IMobileDataFactory CreateMobileData();
    }
}
