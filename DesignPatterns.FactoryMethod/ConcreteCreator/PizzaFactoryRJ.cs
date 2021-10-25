using DesignPatterns.FactoryMethod.ConcreteProduct;
using DesignPatterns.FactoryMethod.AbstractCreator;
using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.ConcreteCreator
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) return new PizzaMussarelaRJ();
            if (tipo.Equals("C")) return new PizzaCalabresaRJ();

            return null;
        }
    }
}
