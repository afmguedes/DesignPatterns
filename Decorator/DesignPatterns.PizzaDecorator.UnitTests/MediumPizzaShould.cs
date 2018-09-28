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
            var smallPizza = new MediumPizza();

            var actualCost = smallPizza.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Medium Pizza";
            var classicPizza = new MediumPizza();

            var actualDescription = classicPizza.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}