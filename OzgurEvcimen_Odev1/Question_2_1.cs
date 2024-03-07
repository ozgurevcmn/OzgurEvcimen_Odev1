using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    public class Question_2_1
    {
        static Dictionary<int, (string Name, decimal Price)> products = new Dictionary<int, (string Name, decimal Price)>()
    {
        {1, ("Organic Avocado", 2.99m)},
        {2, ("Grass-fed Beef", 9.49m)},
        {3, ("Organic Kale", 1.79m)},
        {4, ("Free-range Chicken Eggs", 4.29m)},
        {5, ("Fresh Strawberries", 3.99m)},
        {6, ("Whole Grain Bread", 2.49m)},
        {7, ("Fair Trade Coffee", 7.99m)},
        {8, ("Wild-caught Salmon Fillet", 12.99m)},
        {9, ("Organic Baby Spinach", 2.29m)},
        {10, ("Almond Milk", 3.49m)},
    };

        static Dictionary<int, List<(string ProductName, decimal ProductPrice, int Quantity)>> orders = new Dictionary<int, List<(string ProductName, decimal ProductPrice, int Quantity)>>();
        static int lastOrderNumber = 0;

        public static void Answer()
        {
            while (true)
            {
                Console.WriteLine("1- Create Order\n2- Search Order\n3- Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateOrder();
                        break;
                    case "2":
                        SearchOrder();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateOrder()
        {
            var orderDetails = new List<(string ProductName, decimal ProductPrice, int Quantity)>();
            string another = "y";
            while (another.ToLower() == "y")
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Key}- {product.Value.Name}, Price: ${product.Value.Price}");
                }
                Console.Write("Which product do you want to buy? ");
                int productChoice;
                while (!int.TryParse(Console.ReadLine(), out productChoice)||!products.ContainsKey(productChoice))
                {
                    Console.Write("Invalid input. Please enter a valid product number: ");
                }

                Console.Write("How many? ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
                {
                    Console.Write("Invalid quantity. Please enter a positive number: ");
                }

                var selectedProduct = products[productChoice];
                orderDetails.Add((selectedProduct.Name, selectedProduct.Price, quantity));

                Console.Write("Do you want to buy another product? (y/n) ");
                another = Console.ReadLine();
                while (another.ToLower() != "y" && another.ToLower() != "n")
                {
                    Console.Write("Please answer 'y' or 'n': ");
                    another = Console.ReadLine();
                }
            }

            lastOrderNumber++;
            orders.Add(lastOrderNumber, orderDetails);
            Console.WriteLine($"Order created successfully. Your order number is {lastOrderNumber}.");
        }

        static void SearchOrder()
        {
            Console.Write("Enter your order number: ");
            int orderNumber;
            decimal totalOrderPrice=0;
            while (!int.TryParse(Console.ReadLine(), out orderNumber) || !orders.ContainsKey(orderNumber))
            {
                Console.Write("Invalid order number. Please enter a valid order number: ");
            }

            Console.WriteLine($"Order {orderNumber} details:");
            foreach (var item in orders[orderNumber])
            {
                Console.WriteLine($"Product: {item.ProductName}, Quantity: {item.Quantity}, Total Price: {item.ProductPrice * item.Quantity:C2}");
                totalOrderPrice += (item.ProductPrice * item.Quantity);
            }
            Console.WriteLine($"Total Order Price: ${totalOrderPrice}");
        }
    }

}

