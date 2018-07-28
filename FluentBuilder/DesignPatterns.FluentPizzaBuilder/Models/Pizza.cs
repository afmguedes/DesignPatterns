using System.Collections.Generic;

namespace DesignPatterns.FluentPizzaBuilder
{
	public class Pizza
	{
		public List<Toppings> Toppings = new List<Toppings>();
		public SauceType SauceType;
		public Size Size;
		public CrustType Crust;
	}
}