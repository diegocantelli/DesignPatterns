using System;
using System.Collections.Generic;

namespace DesignPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interpreter: Define uma representação para sua gramática junto com um intérprete que usa a representação
            // para interpretar frases na linguagem

            List<IExpression> expressoes = new List<IExpression>();
            Context context = new Context(DateTime.Now);

            Console.WriteLine("Selecio a expressão a usar: MM-DD-YYYY, YYYY-MM-DD ou DD-MM-YYYY");

            context.Expressao = Console.ReadLine().ToUpper();

            string[] formato = context.Expressao.Split();

            foreach (var item in formato)
            {
                if(item == "DD")
                {
                    expressoes.Add(new ExpressaoDia());
                } 
                else if (item == "MM") 
                {
                    expressoes.Add(new ExpressaoMes());
                }
                else if (item == "YYYY")
                {
                    expressoes.Add(new ExpressaoAno());
                }
            }

            expressoes.Add(new Separador());

            foreach (var obj in expressoes)
            {
                obj.Avaliar(context);
            }

            Console.WriteLine($"\nData na expressão escolhida: ${context.Expressao}");

            Console.Read();
            
        }
    }
}
