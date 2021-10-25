using DesignPatterns.FactoryMethod.AbstractProduct;

namespace DesignPatterns.FactoryMethod.ConcreteProduct
{
    public class PizzaMussarelaSP : Pizza
    {

        public PizzaMussarelaSP()
        {
            Nome = "Pizza de Mussarela Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho Paulista";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Azeitonas Verdes");
        }

        public override void Preparar()
        {
            System.Console.WriteLine("Preparando pizza de Mussarela Paulista");
        }
    }
}
