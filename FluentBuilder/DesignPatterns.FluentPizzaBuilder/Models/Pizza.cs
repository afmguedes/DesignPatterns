using System.Collections.Generic;
using System.Text;
using DesignPatterns.FluentPizzaBuilder.Enums;

namespace DesignPatterns.FluentPizzaBuilder.Models
{
	public class Pizza
	{
		public Size Size;
		public Crusts Crust;
		public Sauces Sauce;
		public List<Toppings> Toppings = new List<Toppings>();

		public override string ToString()
		{
			var stringBuilder = new StringBuilder();

			stringBuilder.Append($"{Size} Pizza");
			stringBuilder.Append($" with {Crust} Crust");
			stringBuilder.Append($", {Sauce} Sauce");
			stringBuilder.AppendLine(" and:");

			foreach (var topping in Toppings)
			{
				stringBuilder.AppendLine($"{topping}");
			}

			return stringBuilder.ToString();
		}
	}
}