using System;
using DesignPatterns.FactoryMethod.Concrete;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Factorys
{
    public class PrePaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public PrePaidMobilePlanFactory()
        {
        }

        public override IMobilePlan CreateMobilePlan()
        {
            var prepaidMobilePlan = new PrePaidMobilePlan();

            prepaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "Low Connection Speed",
                Velocity = 50
            };

            prepaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "Prepaid Text Message",
                QuantityPerMonth = 2000

            };

            prepaidMobilePlan.PrePaidIntegration();

            return prepaidMobilePlan;
        }
    }
}
