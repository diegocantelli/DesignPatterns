using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.MultiThread
{
    public class SingletonMultiThread
    {
        public static SingletonMultiThread Instance;

        // Objeto criado apenas para poder controlar o acesso das threads
        private static object lockObject = new object();

        private SingletonMultiThread()
        {

        }

        public static SingletonMultiThread GetInstance()
        {
            // Necessário fazer essas duas verificações para garantir que cada thread verifica a instância
            // e para não ficar dando "lock" no objeto caso a instância já esteja criada, tornando o algoritmo mais performático
            if(Instance == null)
            {
                lock (lockObject)
                {
                    Instance ??= new SingletonMultiThread();
                }
            }

            return Instance; 
        }
    }
}
