using DesignPatterns.Adapter.Adapter;
using DesignPatterns.Adapter.Target;
using System;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adapter: Adapta uma interface em outra de acordo com a expectativa do cliente
            // Permite a colaboração de objetos com interfaces incompatíveis

            // Adaptador de objeto: Essa implementação usa o princípio de composição do objeto: o adaptador implementa a interface de
            // um objeto e o implementa em outro

            string[,] alunos = new string[5, 4]
            {
                {"101", "maria", "Artes", "1000" },
                {"102", "Joao", "Matemática", "1000" },
                {"103", "Luis", "História", "1000" },
                {"104", "Roberto", "Artes", "1000" },
                {"105", "Luisa", "Artes", "1000" },
            };

            ITarget target = new AlunoAdapter();

            target.ProcessaCalculoMensalidade(alunos);
        }
    }
}
