using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.Decorator
{
    public abstract class ExtrasDecorator : Pizza
    {
        protected Pizza pizza;
        protected double cost;
        protected string description;

        protected ExtrasDecorator(Pizza pizza)
        {
            this.pizza = pizza;
            Size = pizza.Size;
            Sauce = pizza.Sauce;
            Crust = pizza.Crust;
            Toppings = pizza.Toppings;
            cost = 0.0;
            description = string.Empty;
        }

        public override double GetCost()
        {
            return pizza.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return $"{pizza.GetDescription()}\r\n\t- {description}";
        }
    }
}