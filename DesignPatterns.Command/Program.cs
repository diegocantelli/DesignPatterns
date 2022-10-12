using System;
using System.Collections.Generic;
using DesignPatterns.Command.Commands;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command
{
    //Padrao utilizado quando se possui uma determinada acao(comando) que encapsula dentro de si várias operacões
    //e que para ser executada com sucesso, é necessario que todas as operacoes sejam executadas com sucesso, caso contrario
    //o estado deve ser revertido para o anterior à execucao do comando

    //Atraves deste padrao tbm é possível comunicar de forma clara a intençao do código em relação à regra de negócio
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Id = 1,
                FullName = "Customer example"
            };

            var creditCard = new CreditCard()
            {
                Id = 1,
                ExpirationDate = new DateTime(2030, 12, 31),
                HolderName = "Customer example",
                SecurityCode = "333"
            };

            var purchase = new Purchase()
            {
                CreditCard = creditCard,
                Date = DateTime.Now,
                Customer = customer,
                Product = new Product
                {
                    Name = "Book",
                    Supplier = new Supplier
                    {
                        Name = "Plura Sight"
                    }
                }
            };

            IPurchaseCommand paymentCommand = new CreditCardPaymentCommand(purchase);
            IPurchaseCommand storageCommand = new StorageManagerCommand(purchase);
            IPurchaseCommand supplierCommand = new SupplierCommand (purchase);

            var listPurchasedCommands = new List<IPurchaseCommand>()
            {
                paymentCommand,
                storageCommand,
                supplierCommand
            };

            new TransactionPurchaseCommand(listPurchasedCommands).ExecuteOperation();
        }
    }
}