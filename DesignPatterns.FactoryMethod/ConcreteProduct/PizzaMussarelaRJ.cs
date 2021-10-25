using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.ConcreteProduct
{
    public class PizzaMussarelaRJ : Pizza
    {

        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho Carioca";
            Ingredientes.Add("Azeitonas Pretas");
        }

        public override void Preparar()
        {
            System.Console.WriteLine("Preparando pizza de mussarela Carioca.");
        }
    }
}
