using System;
namespace DesignPatterns.FactoryMethod.Interfaces
{
    public interface IMobilePlan
    {
        IConnectionSpeed ConnectionSpeed { get; set; }
        ITextMessage TextMessage { get; set; }
    }
}
