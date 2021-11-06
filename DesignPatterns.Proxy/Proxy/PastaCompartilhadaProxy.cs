using DesignPatterns.Proxy.RealSubject;
using DesignPatterns.Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pastaCompartilhada;
        private Funcionario _funcionario;

        public PastaCompartilhadaProxy(Funcionario func)
        {
            _funcionario = func;
        }
        public void OperacaoDeLeituraGravacao()
        {
            if(_funcionario.Perfil.ToUpper() == "CEO")
            {
                pastaCompartilhada = new PastaCompartilhada();
                Console.WriteLine("Será chamado o método OperacaoLeituraGravacao da pasta compartilhada Real");
                pastaCompartilhada.OperacaoDeLeituraGravacao();
            } else
            {
                Console.WriteLine("Você não tem permissão para acessar esta pasta.");
            }
        }
    }
}
