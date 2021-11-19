using ExercicioCursoCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCursoCSharp {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of list:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: R$ ");
                double price = double.Parse(Console.ReadLine());
                
                if(choice == 'i') {
                    Console.Write("CUSTOMS FREE: R$ ");
                    double customsfree = double.Parse(Console.ReadLine());
                   
                    list.Add(new ImportedProduct(name, price, customsfree));                
                }else if(choice == 'u') {
                    Console.Write("MANUFACTURE DATE  (DD/MM/YYYY): ");
                    DateTime mdate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, mdate));
                }

                list.Add(new Product(name, price));
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
