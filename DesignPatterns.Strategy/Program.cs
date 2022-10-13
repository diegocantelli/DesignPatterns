using System;
using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy
{
    // Este padrao é recomendado quando existem lógicas de negocio que devem ser seguidas em pontos e situacoes diferentes
    // da aplicacao, mas as regras que implementam essas lógicas de negócio mudam conforme a situação
    // Ex: ApplyTax e ApplyProfit sao lógicas de negocio que todas as cidades devem implementar
    //     A implementação desses métodos que pode mudar de uma cidade para outra
    // Caso houvesse uma grande divergência nas lógicas de negócio aplicadas por diferentes cidades, este padrao nao seria
    // o mais recomendado
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                CityCode = "NYC",
                City = "New York"
            };

            var cityStrategyMethod = new CityStrategyMethod();
            var cityStrategy = cityStrategyMethod.SetCityStrategy(user.CityCode);

            var delivery = new Delivery(cityStrategy);
            delivery.Price = 10;
            cityStrategy.ApplyEmploymentRule();
            Console.WriteLine($"Tax: {delivery.Tax}");
            Console.WriteLine($"Profit: {delivery.Profit}");

            Console.ReadLine();
        }
    }
}
