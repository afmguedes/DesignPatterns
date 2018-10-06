using DesignPatterns.PizzaDecorator.Components;
using DesignPatterns.PizzaDecorator.Decorator;

namespace DesignPatterns.PizzaDecorator.ConcreteDecorators
{
    public class ToppingDecorator : ExtrasDecorator
    {
        public ToppingDecorator(Pizza pizza, Toppings topping)
            : base(pizza)
        {
            cost = PricingClient.GetToppingCost(topping);
            description = topping.ToString();
        }
    }
}