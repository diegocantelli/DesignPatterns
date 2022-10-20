using System;
using System.Collections.Generic;

namespace DesignPatterns.Models
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cpf, double? valorBruto = 10)
        {
            if(string.IsNullOrEmpty(razaoSocial))
                throw new Exception("Razao Social deve ser informada");

            if (string.IsNullOrEmpty(cpf))
                throw new Exception("Cpf deve ser informado");
            
            RazaoSocial = razaoSocial;
            Cpf = cpf;
            ValorBruto = valorBruto;

        }

        public string RazaoSocial { get; set; }
        public string Cpf { get; set; }
        public DateTime DataEmissao { get; set; }
        public double? ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }
    }
}
