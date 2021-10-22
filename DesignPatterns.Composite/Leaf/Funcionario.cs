using DesignPatterns.Composite.Component;
using System;

namespace DesignPatterns.Composite.Leaf
{
    public class Funcionario : EstruturaOrganizacional
    {
        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O funcionário {Nome} registrou {Horas}(s) trabalhadas.");
            return Horas;
        }
    }
}
