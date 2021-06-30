using System;

namespace Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Product Manager");
                Console.WriteLine("------------------");
                Console.WriteLine("o 1. Add product records");
                Console.WriteLine("o 2. Display product records");
                Console.WriteLine("o 3. Delete product by Id");
                Console.WriteLine("o 4. Exit");
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter your choice (1 - 4) :");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        productController.Add();
                        break;
                    case 2:
                        productController.Display();
                        break;
                    case 3:
                        productController.Delete();
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}