using System;
using System.Xml;
using DesignPatterns.Adapter.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.Adapter.Adapter
{
    public class CustomerAdapter : CustomerLogic, ICustomer
    {
        public override string GetCustomers()
        {
            // obtem o retorno em XML do sistema 'legado'
            string originalXml = base.GetCustomers();
            var xmlDocumento = new XmlDocument();
            xmlDocumento.LoadXml(originalXml);

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            var customers = JsonConvert.SerializeObject(xmlDocumento, jsonSettings);

            return customers;
        }
        public CustomerAdapter()
        {
        }
    }
}
