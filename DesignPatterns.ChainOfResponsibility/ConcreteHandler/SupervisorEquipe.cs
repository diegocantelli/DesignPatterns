using DesignPatterns.ChainOfResponsibility.AbstractHandler;
using System;

namespace DesignPatterns.ChainOfResponsibility.ConcreteHandler
{
    public class SupervisorEquipe : Autorizador
    {
        const int ALCADA_DIAS = 15;
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
            Console.WriteLine($"Férias de {_diasSolicitados} aprovada pelo Supervisor de equipe para o funcionário: {_nome}");
        }
    }
}
