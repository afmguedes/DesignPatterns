using System;
using DesignPatterns.CORPizzaRestaurant;

namespace DesignPatterns.PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var headChef = new HeadChef("Thiago");
            var kitchenManager = new KitchenManager("Jonathan");
            var generalManager = new GeneralManager("Yuliya");
            var restaurant = new CORPizzaRestaurant.PizzaRestaurant(headChef, kitchenManager, generalManager);

            Console.WriteLine("Welcome to Buona Sera Restaurant Order Approval System\n\n");

            Console.WriteLine("Current hierarchy:\n");
            foreach (var type in restaurant.GetHierarchy())
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Order Approvals:\n");
            var ordersToApprove = new[] { 1000, 150, 250, 10, 5000, 450, 600, 75, 50 };

            foreach (var approval in restaurant.ProcessOrders(ordersToApprove))
            {
                Console.WriteLine(approval);
            }

            Console.ReadKey();
        }
    }
}
