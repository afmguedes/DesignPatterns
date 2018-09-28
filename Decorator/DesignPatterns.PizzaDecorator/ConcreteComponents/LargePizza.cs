using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class LargePizza : IPizza
    {
        public double GetCost()
        {
            return 7.0;
        }

        public string GetDescription()
        {
            return "Large Pizza";
        }
    }
}