using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    internal class SauceDecoratorShould
    {
        [Test]
        public void ReturnSmallPizzaWithSauceDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Small Pizza\r\n\t- Tomato sauce";
            var smallPizza = new SmallPizza();
            var sauceDecorator = new SauceDecorator(smallPizza, Sauces.Tomato);

            var actualDescription = sauceDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }

        [Test]
        public void ReturnSmallPizzaWithSpecialSauceCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.5;
            var smallPizza = new SmallPizza();
            var crustDecorator = new SauceDecorator(smallPizza, Sauces.Barbecue);

            var actualCost = crustDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaWithStandardSauceCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.25;
            var smallPizza = new SmallPizza();
            var crustDecorator = new SauceDecorator(smallPizza, Sauces.Tomato);

            var actualCost = crustDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }
    }
}