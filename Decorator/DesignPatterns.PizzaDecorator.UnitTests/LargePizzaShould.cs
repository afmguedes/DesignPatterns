using DesignPatterns.PizzaDecorator.ConcreteComponents;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class LargePizzaShould
    {
        [Test]
        public void ReturnCost_WhenGetCostIsCalled()
        {
            var expectedCost = 7.0;
            var largePizza = new LargePizza();

            var actualCost = largePizza.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Large Pizza";
            var largePizza = new LargePizza();

            var actualDescription = largePizza.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}