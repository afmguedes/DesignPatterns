namespace DesignPatterns.FluentPizzaBuilder.Interfaces
{
	public interface IPizzaBuilderSauce
	{
		IPizzaBuilderToppings WithSauce(SauceType selectedSauce);
	}
}