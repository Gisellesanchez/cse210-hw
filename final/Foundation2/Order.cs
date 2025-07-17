using System;
using System.Collections.Generic;


namespace Foundation2
{
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Customer Customer { get; set; }
        public Order(Customer customer)
        {
            Customer = customer;
       
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public decimal GetTotalCost()
     {
        decimal total = 0;
        foreach (var product in Products)
            {
                total += product.GetTotalCost();
            }

            total += Customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"- {product.GetPackingLabel()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.GetName()}\n{Customer.GetAddress()}";
    }
     public override string ToString()
        {
            return string.Join(", ", Products);
        }
    }
}