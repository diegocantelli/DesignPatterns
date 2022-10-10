using System;
using System.Collections.Generic;
using DesignPatterns.Composite.Interfaces;

namespace DesignPatterns.Composite.Concretes
{
    //Esta é a classe composite do padrao. É obrigatório existir uma lista de objetos
    //que implementam a interface IProduct
    public class Combo : IProduct
    {

        private List<IProduct> _subProducts;

        public Combo()
        {
            _subProducts = new List<IProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
            Console.WriteLine("***** All the products in this Combo *****");

            foreach (var subproduct in _subProducts)
            {
                subproduct.GetProductDetails();
            }
        }

        public decimal GetProductPrice()
        {
            this.Price = 0;

            /*caso _subProducts tbm seja um combo, ira chamar este metodo de forma recursiva
              ate achar o ultimo nivel, que será um produto, sendo assim irá calcular o valor chamando o método
              GetProductPrice implementado na classe Produto. Caso este comportamento nao seja possivel,
              entao o padrao  composite nao foi implementado corretamente
            */
            foreach (var subproduct in _subProducts)
            {
                this.Price += subproduct.GetProductPrice();
            }

            Console.WriteLine($"**** Total price: {this.Price}");
            return this.Price;
        }

        public void AddProduct(IProduct product)
        {
            _subProducts.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            _subProducts.Remove(product);
        }
    }
}
