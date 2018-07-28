namespace DesignPatterns.FluentPizzaBuilder
{
	public class PizzaBuilder
	{
		private Pizza pizza = new Pizza();

		public PizzaBuilder WithSize(Size selectedSize)
		{
			pizza.Size = selectedSize;
			return this;
		}

		public PizzaBuilder WithCrust(CrustType selectedCrust)
		{
			pizza.Crust = selectedCrust;
			return this;
		}

		public PizzaBuilder WithSauce(SauceType selectedSauce)
		{
			pizza.SauceType = selectedSauce;
			return this;
		}

		public PizzaBuilder AddTopping(Toppings selectedTopping)
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