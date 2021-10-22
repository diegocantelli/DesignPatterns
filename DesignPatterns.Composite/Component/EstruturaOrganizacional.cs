using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Component
{
    public abstract class EstruturaOrganizacional
    {
        public EstruturaOrganizacional()
        {

        }

        public string Nome { get; set; }
        public int Horas { get; set; }
        public abstract int GetHoraTrabalhada();
    }
}
