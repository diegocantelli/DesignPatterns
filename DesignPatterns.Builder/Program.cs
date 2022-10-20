using System;

namespace DesignPatterns.Builder
{
    /*Sempre que tivermos um objeto complexo de ser criado, que possui diversos
    atributos, ou que possui uma lógica de criação complicada, podemos esconder
    tudo isso em um Builder.

    Além de centralizar o código de criação e facilitar a manutenção, ainda facilitamos
    a vida das classes que precisam criar essa classe complexa, afinal a interface
    do Builder tende a ser mais clara e fácil de ser usada. */

    class Program
    {
        static void Main(string[] args)
        {
            var nfBuilder = new NotaFiscalBuilder();

            var nf = nfBuilder
                .WithCpf("1234535353")
                .WithRazaoSocial("Teste padrao builder")
                .WithValorBruto(20)
                .Build();

            Console.WriteLine("Razao social: " + nf.RazaoSocial);
            Console.WriteLine("Cpf: " + nf.Cpf);
            Console.WriteLine("Valor Bruto: " + nf.ValorBruto);

            Console.ReadLine();
        }
    }
}
