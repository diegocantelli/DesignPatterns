using System;
using System.Collections.Generic;
using DesignPatterns.State;

namespace DesignPatterns.Models
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }
        public EstadoDeUmOrcamento EstadoDeUmOrcamento { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoDeUmOrcamento.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoDeUmOrcamento.Aprova(this);
        }

        public void Reprova()
        {
            EstadoDeUmOrcamento.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoDeUmOrcamento.Finaliza(this);
        }
    }
}
