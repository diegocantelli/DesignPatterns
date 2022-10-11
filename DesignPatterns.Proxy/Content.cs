using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Content
    {

        public Content()
        {
        }

        public int Id { get; set; }
        public News News { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public CategoryEnum CategoryEnum { get; set; }
    }

    public enum CategoryEnum
    {
        Sports = 1,
        Technology = 2,
        Health = 3,
        Lifestyle = 4,
        Education = 5
    }
}
