using DesignPatterns.Composite.Component;
using DesignPatterns.Composite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Composite
{
    public class Organizacao : EstruturaOrganizacional, IManipulaEstruturaOrganizacional
    {
        protected List<EstruturaOrganizacional> departamentos = new List<EstruturaOrganizacional>();

        public void Add(EstruturaOrganizacional component)
        {
            departamentos.Add(component);
        }

        public void Remove(EstruturaOrganizacional component)
        {
            departamentos.Remove(component);
        }
        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;

            foreach (var departamento in departamentos)
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
            }

            Console.WriteLine($"{Nome} registrou um total de {Horas}(s) trabalhadas.");

            return horasTrabalhadasDepartamento;
        }
    }
}
