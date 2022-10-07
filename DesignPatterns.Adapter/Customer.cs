using System;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    [Serializable]
    public class Customer
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Address { get; set; }

        [XmlAttribute]
        public string City { get; set; }

        [XmlAttribute]
        public string Country { get; set; }

        [XmlAttribute]
        public string DocumentNumber { get; set; }

        [XmlAttribute]
        public DateTime Birthday { get; set; }


        public Customer()
        {
        }
    }
}
