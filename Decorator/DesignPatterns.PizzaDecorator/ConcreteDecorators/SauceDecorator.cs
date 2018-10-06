using DesignPatterns.PizzaDecorator.Components;
using DesignPatterns.PizzaDecorator.Decorator;

namespace DesignPatterns.PizzaDecorator.ConcreteDecorators
{
    public class SauceDecorator : ExtrasDecorator
    {
        public SauceDecorator(Pizza pizza, Sauces sauce)
            :base(pizza)
        {
            Sauce = sauce;

            cost = PricingClient.GetSauceCost(Sauce);
            description = $"{Sauce} sauce";
        }
    }
}