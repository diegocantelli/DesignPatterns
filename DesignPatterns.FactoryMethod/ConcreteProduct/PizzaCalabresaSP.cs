using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.ConcreteProduct
{
    public class PizzaCalabresaSP : Pizza
    {

        public PizzaCalabresaSP()
        {
            Nome = "Pizza de calabresa Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho Paulista";
            Ingredientes.Add("Azeitonas Verdes");
        }

        public override void Preparar()
        {
            System.Console.WriteLine("Preparando pizza de calabresa Paulista.");
        }
    }
}
