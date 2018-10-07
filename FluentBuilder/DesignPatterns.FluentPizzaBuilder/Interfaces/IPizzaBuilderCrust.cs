using DesignPatterns.FluentPizzaBuilder.Enums;

namespace DesignPatterns.FluentPizzaBuilder.Interfaces
{
	public interface IPizzaBuilderCrust
	{
		IPizzaBuilderSauce WithCrust(Crusts selectedCrust);
	}
}