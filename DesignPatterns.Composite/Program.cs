using DesignPatterns.Composite.Composite;
using DesignPatterns.Composite.Leaf;
using System;

namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definição: Composite compõe objetos em estruturas semelhantes a uma árvore para representar hierarquias parte-todo
            // permite que os clientes tratem objetos individuais e composições de maneira uniforme

            // Estrutura:
            //  - Component: É uma interface que descreve elementos comuns a elementos simples ou complexos da árvore.
            //  - Leaf: É um único objeto que não possui sub-elementos
            //  - Composite: É um objeto que possui sub-elementos 

            Organizacao organizacao = new Organizacao { Nome = "Organização 1" };

            Organizacao departamentoTI = new Organizacao { Nome = "Departamento TI" };
            departamentoTI.Add(new Funcionario { Nome = "Func TI 1", Horas = 40 });
            departamentoTI.Add(new Funcionario { Nome = "Func TI 2", Horas = 44 });

            Organizacao contabilidade = new Organizacao { Nome = "Contabilidade" };
            contabilidade.Add(new Funcionario { Nome = "Func Conta. 1", Horas = 40 });
            contabilidade.Add(new Funcionario { Nome = "Func Conta. 2", Horas = 44 });

            organizacao.Add(departamentoTI);
            organizacao.Add(contabilidade);

            organizacao.GetHoraTrabalhada();

            Console.ReadKey();

        }
    }
}
