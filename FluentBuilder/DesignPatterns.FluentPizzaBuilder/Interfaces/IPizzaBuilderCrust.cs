namespace DesignPatterns.FluentPizzaBuilder.Interfaces
{
	public interface IPizzaBuilderCrust
	{
		IPizzaBuilderSauce WithCrust(CrustType selectedCrust);
	}
}