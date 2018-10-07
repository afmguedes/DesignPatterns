using DesignPatterns.FluentPizzaBuilder.Enums;

namespace DesignPatterns.FluentPizzaBuilder.Interfaces
{
    public interface IPizzaBuilderToppings
    {
        IPizzaBuilderToppings AddTopping(Toppings selectedTopping);
    }
}