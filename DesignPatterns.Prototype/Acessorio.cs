using DesignPatterns.Prototype.Prototype;

namespace DesignPatterns.Prototype
{
    public class Acessorio : IClonagem
    {
        public string Nome { get; set; }

        public Acessorio()
        {

        }

        public Acessorio(Acessorio acessorio)
        {
            Nome = acessorio.Nome;
        }

        public object Clone()
        {
            return new Acessorio(this);
        }
    }
}