using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Target
{
    public interface ITarget
    {
        void ProcessaCalculoMensalidade(string[,] alunosArray);
    }
}
