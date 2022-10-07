using System;
using DesignPatterns.Adapter.Adapter;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerAdapter = new CustomerAdapter();
            var customers = customerAdapter.GetCustomers();

            Console.WriteLine(customers);

            Console.ReadLine();
        }
    }
}
