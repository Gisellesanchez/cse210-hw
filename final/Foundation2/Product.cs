using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Foundation2
{
    public class Product
    {
        private string Name { get; set; }
        private string Identification { get; set; }

        private decimal PricePerPackage { get; set; }
        private int Amount { get; set; }

        public Product(string name, string id, decimal price, int amount)
        {
            Name = name;
            Identification = id;
            PricePerPackage = price;
            Amount = amount;
            
        }

       public decimal GetTotalCost()
        {
            return PricePerPackage * Amount;
        }

        public string GetPackingLabel()
        {
            return $"{Name} ({Identification}) - {Amount} @ ${PricePerPackage:F2} each";
        }
    }
    
}