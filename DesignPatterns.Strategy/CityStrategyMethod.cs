using System;
using DesignPatterns.Strategy.Concrete;

namespace DesignPatterns.Strategy
{
    // Essa classe serve como a 'orquestradora' de qual regra de negocio devera ser implementada
    public class CityStrategyMethod
    {
        public CityStrategyMethod()
        {
        }

        public ICityStrategy SetCityStrategy(string cityPrefix)
        {
            ICityStrategy cityStrategy;
            switch (cityPrefix)
            {
                case "NYC":
                    cityStrategy = new NewYorkStrategy();
                    break;
                case "LAC":
                    cityStrategy = new LosAngelesStrategy();
                    break;
                case "SPC":
                    cityStrategy = new SaoPauloStrategy();
                    break;
                default:
                    cityStrategy = new NewYorkStrategy();
                    break;
            }

            return cityStrategy;

        }
    }
}
