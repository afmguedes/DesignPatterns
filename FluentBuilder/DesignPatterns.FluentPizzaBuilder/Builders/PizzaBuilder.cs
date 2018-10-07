using DesignPatterns.FluentPizzaBuilder.Enums;
using DesignPatterns.FluentPizzaBuilder.Interfaces;
using DesignPatterns.FluentPizzaBuilder.Models;

namespace DesignPatterns.FluentPizzaBuilder.Builders
{
	public class PizzaBuilder : IPizzaBuilderCrust, IPizzaBuilderSauce, IPizzaBuilderToppings
	{
		private Pizza pizza = new Pizza();

		public IPizzaBuilderCrust CreatePizzaWithSize(Size selectedSize)
		{
			pizza = new Pizza {Size = selectedSize};
			return this;
		}

		public IPizzaBuilderSauce WithCrust(Crusts selectedCrust)
		{
			pizza.Crust = selectedCrust;
			return this;
		}

		public IPizzaBuilderToppings WithSauce(Sauces selectedSauce)
		{
			pizza.Sauce = selectedSauce;
			return this;
		}

		public IPizzaBuilderToppings AddTopping(Toppings selectedTopping)
		{
			pizza.Toppings.Add(selectedTopping);
			return this;
		}

		public Pizza Bake()
		{
			return pizza;
		}
	}
}