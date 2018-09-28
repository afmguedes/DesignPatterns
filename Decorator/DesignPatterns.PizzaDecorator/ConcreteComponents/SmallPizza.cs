using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class SmallPizza : IPizza
    {
        public double GetCost()
        {
            return 5.0;
        }

        public string GetDescription()
        {
            return "Small Pizza";
        }
    }
}