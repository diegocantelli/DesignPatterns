using DesignPatterns.FlyWeight.ConcreteFlyweight;
using DesignPatterns.FlyWeight.FlyWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight.FlyWeightFactory
{
    public class FormaFactory
    {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        public static IForma GetForma(string chave)
        {
            IForma forma = null;
            
            if (formas.ContainsKey(chave))
            {
                return formas[chave];
            }

            if(chave == "circulo")
            {
                forma = new Circulo();
                formas.Add("circulo", forma);
            }
            return forma;
        }
    }
}
