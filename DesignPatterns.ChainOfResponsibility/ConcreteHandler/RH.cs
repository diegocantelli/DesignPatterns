using DesignPatterns.ChainOfResponsibility.AbstractHandler;
using System;

namespace DesignPatterns.ChainOfResponsibility.ConcreteHandler
{
    // Final da cadeia de processamento
    public class RH : Autorizador
    {
        const int ALCADA_DIAS = 30;
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
                Console.WriteLine($"Não foi possível aprovar as férias para o funcionário {_nome}.");
            }
        }

        private void AprovarFerias()
        {
            Console.WriteLine($"Férias de {_diasSolicitados} aprovada pelo Supervisor de equipe para o funcionário: {_nome}.");
        }
    }
}
