using DesignPatterns.Adapter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Adaptee
{
    public class SistemaMensalidade
    {
        public void CalculaMensalidades(List<Aluno> listaAlunos)
        {
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome}" +
                    $"- Valor da mensalidade: R$ {aluno.Mensalidade}");
            }
        }
    }
}
