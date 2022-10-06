using System;
using DesignPatterns.FactoryMethod.Concrete;
using DesignPatterns.FactoryMethod.Factorys;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMobilePlanFactory prepaidFactory = new PrePaidMobilePlanFactory();
            IMobilePlan prepaidPlan =  prepaidFactory.GetMobilePlan();

            BaseMobilePlanFactory postpaidFactory = new PostPaidMobilePlanFactory();
            IMobilePlan postPaidPlan = postpaidFactory.GetMobilePlan();
        }
    }
}
