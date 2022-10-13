using System;
namespace DesignPatterns.Strategy.Models
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }

    }
}
