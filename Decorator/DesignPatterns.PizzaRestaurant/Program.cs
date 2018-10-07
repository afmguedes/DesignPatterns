using System;
using DesignPatterns.PizzaDecorator;
using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;

namespace DesignPatterns.PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediumPizza = new MediumPizza();
            var mediumPizzaWithAddedSauce = new SauceDecorator(mediumPizza, Sauces.Tomato);
            var mediumPizzaWithAddedCrust = new CrustDecorator(mediumPizzaWithAddedSauce, Crusts.Stuffed);
            var mediumPizzaWithAddedTopping1 = new ToppingDecorator(mediumPizzaWithAddedCrust, Toppings.BlackOlives);
            var mediumPizzaWithAddedTopping2 = new ToppingDecorator(mediumPizzaWithAddedTopping1, Toppings.Bacon);

            Console.WriteLine("Order 1:");
            Console.WriteLine(mediumPizzaWithAddedTopping2.GetDescription());
            Console.WriteLine();
            Console.WriteLine($"Total: {mediumPizzaWithAddedTopping2.GetCost()}");
            Console.WriteLine();

            var smallPizza = new SmallPizza();
            var smallPizzaWithAddedSauce = new SauceDecorator(smallPizza, Sauces.Barbecue);
            var smallPizzaWithAddedCrust = new CrustDecorator(smallPizzaWithAddedSauce, Crusts.Classic);
            var smallPizzaWithAddedTopping1 = new ToppingDecorator(smallPizzaWithAddedCrust, Toppings.Mushrooms);
            var smallPizzaWithAddedTopping2 = new ToppingDecorator(smallPizzaWithAddedTopping1, Toppings.Bacon);

            Console.WriteLine("Order 2:");
            Console.WriteLine(smallPizzaWithAddedTopping2.GetDescription());
            Console.WriteLine();
            Console.WriteLine($"Total: {smallPizzaWithAddedTopping2.GetCost()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
