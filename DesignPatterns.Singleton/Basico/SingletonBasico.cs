using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.Basico
{
    public class SingletonBasico
    {
        public static SingletonBasico instance;

        private SingletonBasico()
        {

        }

        public static SingletonBasico Instance()
        {
            if (instance == null) return new SingletonBasico();

            return instance;
        }
    }
}
