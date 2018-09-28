using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class MediumPizza : IPizza
    {
        public double GetCost()
        {
            return 6.0;
        }

        public string GetDescription()
        {
            return "Medium Pizza";
        }
    }
}