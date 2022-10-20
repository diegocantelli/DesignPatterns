using System;
using DesignPatterns.Models;

namespace DesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {
        public string Cpf { get; private set; }
        public string RazaoSocial { get; private set; }
        public DateTime DataAtual { get; private set; }
        public double? ValorBruto { get; private set; }

        public NotaFiscalBuilder()
        {
        }

        public NotaFiscalBuilder WithCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public NotaFiscalBuilder WithRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder WithValorBruto(double valorBruto)
        {
            ValorBruto = valorBruto;
            return this;
        }

        public NotaFiscal Build()
        {
            return new NotaFiscal(RazaoSocial, Cpf, ValorBruto);
        }
    }
}
