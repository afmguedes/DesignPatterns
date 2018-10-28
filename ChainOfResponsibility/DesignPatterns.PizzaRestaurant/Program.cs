using System;
using DesignPatterns.CORPizzaRestaurant;

namespace DesignPatterns.PizzaRestaurant
{
    class Program
    {
        static void Main()
        {
            var headChef = new HeadChef("Thiago");
            var kitchenManager = new KitchenManager("Jonathan");
            var generalManager = new GeneralManager("Yuliya");
            var restaurant = new CORPizzaRestaurant.PizzaRestaurant(headChef, kitchenManager, generalManager);

            Console.WriteLine("===========================");
            Console.WriteLine("==      WELCOME TO       ==");
            Console.WriteLine("== Buona Sera Restaurant ==");
            Console.WriteLine("== Order Approval System ==");
            Console.WriteLine("===========================\n\n");

            Console.WriteLine("== Current hierarchy ==\n");
            foreach (var employee in restaurant.GetHierarchy())
            {
                Console.WriteLine($"{employee.Item1} as {employee.Item2.Name}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("== Order Approvals ==\n");
            var ordersToApprove = new[] { 1000, 150, 250, 10, 5000, 450, 600, 75, 50 };
            var approvals = restaurant.ProcessOrders(ordersToApprove);

            for (var orderNumber = 1; orderNumber <= ordersToApprove.Length; orderNumber++)
            {
                Console.WriteLine($"Order no {orderNumber}\nTotal cost: {ordersToApprove[orderNumber-1]}\n{approvals[orderNumber-1]}\n");
            }

            Console.ReadKey();
        }
    }
}
