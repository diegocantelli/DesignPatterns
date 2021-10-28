using DesignPatterns.Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.ConcretePrototype
{
    public class Soldado : IClonagem
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public Soldado()
        {

        }

        public Soldado(Soldado s)
        {
            Nome = s.Nome;
            Arma = s.Arma;
            Acessorio = s.Acessorio;
        }
        public object Clone()
        {
            Soldado soldado = (Soldado)this.MemberwiseClone();
            soldado.Acessorio = (Acessorio)this.Acessorio.Clone();

            return soldado;
        }
    }
}
