using DesignPatterns.PizzaDecorator.Components;
using DesignPatterns.PizzaDecorator.Decorator;

namespace DesignPatterns.PizzaDecorator.ConcreteDecorators
{
    public class CrustDecorator : ExtrasDecorator
    {
        public CrustDecorator(Pizza pizza, Crusts crust)
            : base(pizza)
        {
            Crust = crust;

            cost = PricingClient.GetCrustCost(Crust);
            description = $"{Crust} crust";
        }
    }
}