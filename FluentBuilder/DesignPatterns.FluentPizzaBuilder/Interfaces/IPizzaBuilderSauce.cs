namespace DesignPatterns.FluentPizzaBuilder.Interfaces
{
	public interface IPizzaBuilderSauce
	{
		IPizzaBuilderToppings WithSauce(Sauces selectedSauce);
	}
}