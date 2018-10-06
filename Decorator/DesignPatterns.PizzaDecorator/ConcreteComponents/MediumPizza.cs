using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Size = Size.Medium;
        }

        public override double GetCost()
        {
            return PricingClient.GetSizeCost(Size);
        }

        public override string GetDescription()
        {
            return DescriptionsFactory.MediumPizza;
        }
    }
}