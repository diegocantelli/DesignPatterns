using DesignPatterns.ChainOfResponsibility.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.ConcreteHandler
{
    public class GerenteProjetos : Autorizador
    {
        const int ALCADA_DIAS = 5;
        private int _diasSolicitados;
        private string _nome;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if(dias <= ALCADA_DIAS)
            {
                _diasSolicitados = dias;
                _nome = nome;
                AprovarFerias();
            } 
            else
            {
                _autorizador?.AutorizarLicenca(nome, dias);
            }
        }

        private void AprovarFerias()
        {
            Console.WriteLine($"Férias de {_diasSolicitados} aprovada pelo Gerente de projetos para: {_nome}.");
        }
    }
}
