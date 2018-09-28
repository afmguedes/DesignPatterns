using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.Decorator
{
    public class ExtrasDecorator : IPizza
    {
        protected IPizza pizza;

        public ExtrasDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public double GetCost()
        {
            return pizza.GetCost();
        }

        public string GetDescription()
        {
            return pizza.GetDescription();
        }
    }
}