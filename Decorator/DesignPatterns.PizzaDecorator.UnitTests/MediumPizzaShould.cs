using DesignPatterns.PizzaDecorator.ConcreteComponents;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class MediumPizzaShould
    {
        [Test]
        public void ReturnCost_WhenGetCostIsCalled()
        {
            var expectedCost = 6.0;
            var mediumPizza = new MediumPizza();

            var actualCost = mediumPizza.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Medium Pizza";
            var mediumPizza = new MediumPizza();

            var actualDescription = mediumPizza.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}