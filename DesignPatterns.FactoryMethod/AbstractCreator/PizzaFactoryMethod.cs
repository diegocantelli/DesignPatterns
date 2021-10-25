using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.AbstractCreator
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo)
        {
            return CriarPizza(tipo);
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
