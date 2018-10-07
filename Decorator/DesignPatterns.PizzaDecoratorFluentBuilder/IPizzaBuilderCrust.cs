using DesignPatterns.PizzaDecorator;

namespace DesignPatterns.PizzaDecoratorFluentBuilder
{
    public interface IPizzaBuilderCrust
    {
        IPizzaBuilderToppings WithCrust(Crusts selectedCrust);
    }
}