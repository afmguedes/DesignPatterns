using DesignPatterns.PizzaDecorator;

namespace DesignPatterns.PizzaDecoratorFluentBuilder
{
    public interface IPizzaBuilderToppings
    {
        IPizzaBuilderToppings AddTopping(Toppings selectedTopping);
    }
}