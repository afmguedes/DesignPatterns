using DesignPatterns.PizzaDecorator.Components;

namespace DesignPatterns.PizzaDecorator.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Size = Size.Small;
        }

        public override double GetCost()
        {
            return PricingClient.GetSizeCost(Size);
        }

        public override string GetDescription()
        {
            return DescriptionsFactory.SmallPizza;
        }
    }
}