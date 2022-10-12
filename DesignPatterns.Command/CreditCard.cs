using System;
namespace DesignPatterns.Command
{
    public class CreditCard
    {
        public CreditCard()
        {
        }

        public int Id { get; set; }
        public string SecurityCode { get; set; }
        public string HolderName { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
