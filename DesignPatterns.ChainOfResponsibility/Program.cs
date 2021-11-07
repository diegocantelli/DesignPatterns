using DesignPatterns.ChainOfResponsibility.ConcreteHandler;
using System;

namespace DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            // Evita acoplar o remetente de uma solicitação a seu receptor, dando a mais de um objeto a chance de lidar com
            // a solicitação.
            // Esse padrão encadeia os objetos receptores e passa a solicitação ao longo da cadeia até que um objeto a trate

            GerenteProjetos gerenteProjetos = new GerenteProjetos();
            SupervisorEquipe supervisorEquipe = new SupervisorEquipe();
            RH rH = new RH();

            gerenteProjetos.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(rH);

            gerenteProjetos.AutorizarLicenca("diego", 10);
            gerenteProjetos.AutorizarLicenca("joao", 15);
            gerenteProjetos.AutorizarLicenca("maria", 30);
            gerenteProjetos.AutorizarLicenca("jose", 5);

            Console.ReadKey();
        }
    }
}
