using System;
namespace DesignPatterns.Command
{
    public class Customer
    {
        public Customer()
        {
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
