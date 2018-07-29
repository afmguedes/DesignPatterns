using DesignPatterns.FluentPizzaBuilder.Interfaces;

namespace DesignPatterns.FluentPizzaBuilder
{
	public class PizzaBuilder : IPizzaBuilderCrust, IPizzaBuilderSauce, IPizzaBuilderToppings
	{
		private Pizza pizza = new Pizza();

		public IPizzaBuilderCrust WithSize(Size selectedSize)
		{
			pizza.Size = selectedSize;
			return this;
		}

		public IPizzaBuilderSauce WithCrust(CrustType selectedCrust)
		{
			pizza.Crust = selectedCrust;
			return this;
		}

		public IPizzaBuilderToppings WithSauce(SauceType selectedSauce)
		{
			pizza.SauceType = selectedSauce;
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