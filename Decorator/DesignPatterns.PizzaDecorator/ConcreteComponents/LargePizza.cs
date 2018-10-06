using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Size = Size.Large;
        }

        public override double GetCost()
        {
            return PricingClient.GetSizeCost(Size);
        }

        public override string GetDescription()
        {
            return DescriptionsFactory.LargePizza;
        }
    }
}