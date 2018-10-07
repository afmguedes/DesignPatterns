using System;
using DesignPatterns.FluentPizzaBuilder;
using DesignPatterns.FluentPizzaBuilder.Builders;
using DesignPatterns.FluentPizzaBuilder.Enums;

namespace DesignPatterns.PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
			var pizzaiolo = new PizzaBuilder();

	        // Order 01
	        pizzaiolo.CreatePizzaWithSize(Size.Medium)
		        .WithCrust(Crusts.Classic)
		        .WithSauce(Sauces.Barbecue)
		        .AddTopping(Toppings.Pepperoni)
		        .AddTopping(Toppings.GreenPeppers)
		        .AddTopping(Toppings.BlackOlives);

	        var pizza01 = pizzaiolo.Bake();
	        Console.WriteLine(pizza01.ToString());

	        // Order 02
	        pizzaiolo.CreatePizzaWithSize(Size.Small)
		        .WithCrust(Crusts.Thin)
		        .WithSauce(Sauces.No)
		        .AddTopping(Toppings.Mozzarella)
		        .AddTopping(Toppings.Tomatoes);

	        var pizza02 = pizzaiolo.Bake();
	        Console.WriteLine(pizza02.ToString());

	        Console.ReadKey();
		}
    }
}
