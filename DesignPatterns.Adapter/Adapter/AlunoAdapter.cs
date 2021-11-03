using DesignPatterns.Adapter.Adaptee;
using DesignPatterns.Adapter.Domain;
using DesignPatterns.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        // Esta classe não deveria ser passada via construtor, pois não é responsabilidade de quem instancia a AlunoAdapter
        // saber qual classe deverá ser passada para efetuar o cálculo do Adapter
        private SistemaMensalidade sistemaMensalidade = new SistemaMensalidade();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Curso = null;
            string Mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Id = alunosArray[i, j];
                    }
                    else
                    if (j == 1)
                    {
                        Nome = alunosArray[i, j];
                    }
                    else
                    if (j == 2)
                    {
                        Id = alunosArray[i, j];
                    }
                    else
                    {
                        Mensalidade = alunosArray[i, j];
                    }
                }

                listaAlunos.Add(new Aluno(Convert.ToInt32(Id), Nome, Curso, Convert.ToDecimal(Mensalidade)));
            }

            Console.WriteLine("Array de alunos convertido para lista de alunos com sucesso");

            sistemaMensalidade.CalculaMensalidades(listaAlunos);
        }
    }
}
