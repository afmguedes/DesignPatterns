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
            var smallPizza = new LargePizza();

            var actualCost = smallPizza.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Large Pizza";
            var classicPizza = new LargePizza();

            var actualDescription = classicPizza.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}