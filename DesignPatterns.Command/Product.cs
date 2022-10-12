﻿using System;
namespace DesignPatterns.Command
{
    public class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Supplier Supplier { get; set; }
    }
}
