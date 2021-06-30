using System;
using System.Collections.Generic;

namespace Assignment
{
    public class ProductController
    {
        private Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void Add()
        {
            Console.WriteLine("Please enter Product ID");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter Price");
            var price = double.Parse(Console.ReadLine());
            _products.Add(id,new Product()
            {
                Name = name,
                Price = price
                
            });
            Console.WriteLine("Successfully added product");
        }
        public void Delete()
        {
            Console.WriteLine("Please enter ID");
            var id = Console.ReadLine();
            if (_products.ContainsKey(id))
            {
                _products.Remove(id);
                Console.WriteLine("Successfully delete product");
            }
            else
            {
                Console.WriteLine("Product does not exist");
            }
        }
        public void Display()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("There are no product in the system");
                return;
            }
            else
            {
                Console.WriteLine("Product ID \t Name \t Price");
                foreach (var product in _products)
                {
                    Console.WriteLine($"{product.Key} \t {product.Value}");
                }
            }
        }
    }
}