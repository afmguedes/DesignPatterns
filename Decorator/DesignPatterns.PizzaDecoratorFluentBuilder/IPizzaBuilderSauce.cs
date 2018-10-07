using DesignPatterns.PizzaDecorator;

namespace DesignPatterns.PizzaDecoratorFluentBuilder
{
    public interface IPizzaBuilderSauce
    {
        IPizzaBuilderCrust WithSauce(Sauces selectedSauce);
    }
}