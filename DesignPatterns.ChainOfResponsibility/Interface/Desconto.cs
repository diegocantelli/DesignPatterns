using System;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.Interface
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);

        // irá receber uma instancia de uma classe concreta que implementa uma regra de desconto
        Desconto Proximo { get; set; }
    }
}
