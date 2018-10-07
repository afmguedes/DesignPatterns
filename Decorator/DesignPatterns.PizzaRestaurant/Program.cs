using System;
using System.Text;
using DesignPatterns.PizzaDecorator;
using DesignPatterns.PizzaDecorator.Components;
using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;
using DesignPatterns.PizzaDecoratorFluentBuilder;

namespace DesignPatterns.PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaiolo = new PizzaBuilder();

            // Order 01
            pizzaiolo.CreatePizzaWithSize(Size.Medium)
                .WithSauce(Sauces.Barbecue)
                .WithCrust(Crusts.Classic)
                .AddTopping(Toppings.Pepperoni)
                .AddTopping(Toppings.GreenPeppers)
                .AddTopping(Toppings.BlackOlives);

            var pizza01 = pizzaiolo.Bake();
            Console.WriteLine(PrintOrder(pizza01));

            // Order 02
            pizzaiolo.CreatePizzaWithSize(Size.Small)
                .WithSauce(Sauces.No)
                .WithCrust(Crusts.Thin)
                .AddTopping(Toppings.Mozzarella)
                .AddTopping(Toppings.Tomatoes);

            var pizza02 = pizzaiolo.Bake();
            Console.WriteLine(PrintOrder(pizza02));

            Console.ReadKey();
        }

        private static string PrintOrder(Pizza pizza)
        {
            var order = new StringBuilder();

            order.AppendLine("Description:");
            order.AppendLine($"{pizza.GetDescription()}");
            order.AppendLine();
            order.AppendLine($"Total: £{pizza.GetCost():F2}");
            order.AppendLine();

            return order.ToString();
        }
    }
}
