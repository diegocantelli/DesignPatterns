using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    public class CustomerLogic
    {
        private List<Customer> customers;

        public CustomerLogic()
        {
            customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Diego", City = "New York" });
            customers.Add(new Customer { Id = 2, Name = "Customer 2", City = "Sao Paulo" });
            customers.Add(new Customer { Id = 3, Name = "Customer 3", City = "Rio de Janeiro" });
            customers.Add(new Customer { Id = 4, Name = "Customer 4", City = "Miami" });
        }

        public virtual string GetCustomers()
        {
            var xmlSerializer = new XmlSerializer(customers.GetType());

            using(var stream = new StringWriter())
            {
                using(var xmlWriter = XmlWriter.Create(stream))
                {
                    xmlSerializer.Serialize(xmlWriter, customers);
                    return stream.ToString();
                }
            }
        }
    }
}
