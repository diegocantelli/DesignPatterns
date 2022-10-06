using System;
using DesignPatterns.FactoryMethod.Concrete;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Factorys
{
    public class PostPaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public PostPaidMobilePlanFactory()
        {
        }

        public override IMobilePlan CreateMobilePlan()
        {
            var prepaidMobilePlan = new PostPaidMobilePlan();

            prepaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "High Connection Speed",
                Velocity = 500
            };

            prepaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "PostPaid Text Message",
                QuantityPerMonth = 20000

            };

            prepaidMobilePlan.PostPaidIntegration();

            return prepaidMobilePlan;
        }
    }
}
