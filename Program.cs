using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main (string[]args)
        {   
            System.Console.WriteLine("Enter Client data: ");
            System.Console.Write("Name: ");
            string clientName = Console.ReadLine();
            System.Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            System.Console.Write("Birth date (MM/DD/YYYY)");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine()); 
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(clientName, clientEmail, clientBirthDate);
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many item to this order? ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                System.Console.WriteLine("enter #"+ i + " item data: ");
                Console.Write("Product name: ");
                string produtcName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(produtcName, productPrice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
            }
            System.Console.WriteLine();
            System.Console.WriteLine(order);
        }   
    }
}