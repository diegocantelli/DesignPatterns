using System;
using System.Linq;
using DesignPatterns.Proxy.Proxy;

namespace DesignPatterns.Proxy
{
    //O proposito do padrao proxy é criar uma camada intermediária para gerenciar acessos
    //a recursos específicos que possuem regras adicionais para serem acessados ou regras adicionais
    //para retornar determinados valores com base em situações específicas, sem que isso altere e afete
    //a forma em que está implementado o recurso original
    class Program
    {
        static void Main(string[] args)
        {
            var contentRepository = new ContentRepositoryProxy(DeviceType.Web);

            var contentListForWeb = contentRepository.GetContent();

            Console.WriteLine($"Web: " + contentListForWeb.Count() + ", Has ads " +
               contentListForWeb.Any(x => x.Advertisements.Count() > 0));
        }
    }
}
