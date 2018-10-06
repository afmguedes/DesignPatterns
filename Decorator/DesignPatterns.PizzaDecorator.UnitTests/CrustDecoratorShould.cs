using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class CrustDecoratorShould
    {
        [Test]
        public void ReturnSmallPizzaWithCrustDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Small Pizza\r\n\t- Classic crust";
            var smallPizza = new SmallPizza();
            var crustDecorator = new CrustDecorator(smallPizza, Crusts.Classic);

            var actualDescription = crustDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }

        [Test]
        public void ReturnSmallPizzaWithSpecialCrustCost_WhenGetCostIsCalled()
        {
            var expectedCost = 6.0;
            var smallPizza = new SmallPizza();
            var crustDecorator = new CrustDecorator(smallPizza, Crusts.Stuffed);

            var actualCost = crustDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaWithStandardCrustCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.0;
            var smallPizza = new SmallPizza();
            var crustDecorator = new CrustDecorator(smallPizza, Crusts.Classic);

            var actualCost = crustDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }
    }
}