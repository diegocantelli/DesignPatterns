using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }

        public Funcionario(string nome, string senha, string perfil)
        {
            Nome = nome;
            Senha = senha;
            Perfil = perfil;
        }
    }
}
