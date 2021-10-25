using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.ConcreteProduct
{
    public class PizzaCalabresaRJ : Pizza
    {

        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabresa Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho Carioca";
            Ingredientes.Add("Azeitonas Pretas");
        }

        public override void Preparar()
        {
            System.Console.WriteLine("Preparando pizza de calabresa Carioca.");
        }
    }
}
