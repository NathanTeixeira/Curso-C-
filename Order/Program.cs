using Pedido.Entities;
using Pedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Client c = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, c);

            Console.WriteLine("How many items to this order? ");
            int itensQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itensQuantity; i++) {
                Console.WriteLine("Enter #"+ i +"item data: ");
                Console.Write("Product Name: ");
                String pname = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Product p = new Product(pname, price);

                Console.Write("Quantity: ");               
                int quantity = int.Parse(Console.ReadLine());

                OrderItem oI = new OrderItem(quantity, price, p);
                order.AddItem(oI);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.Write(order);

        }
    }
}
