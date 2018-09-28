using DesignPatterns.PizzaDecorator.ConcreteComponents;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class SmallPizzaShould
    {
        [Test]
        public void ReturnCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.0;
            var smallPizza = new SmallPizza();

            var actualCost = smallPizza.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Small Pizza";
            var classicPizza = new SmallPizza();

            var actualDescription = classicPizza.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}