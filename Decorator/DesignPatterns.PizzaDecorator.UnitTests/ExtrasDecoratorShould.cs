using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.Decorator;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class ExtrasDecoratorShould
    {
        [Test]
        public void ReturnLargePizzaOriginalCost_WhenGetCostIsCalled()
        {
            var expectedCost = 7.0;
            var largePizza = new LargePizza();
            var extrasDecorator = new ExtrasDecorator(largePizza);

            var actualCost = extrasDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnLargePizzaOriginalDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Large Pizza";
            var largePizza = new LargePizza();
            var extrasDecorator = new ExtrasDecorator(largePizza);

            var actualDescription = extrasDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }

        [Test]
        public void ReturnMediumPizzaOriginalCost_WhenGetCostIsCalled()
        {
            var expectedCost = 6.0;
            var mediumPizza = new MediumPizza();
            var extrasDecorator = new ExtrasDecorator(mediumPizza);

            var actualCost = extrasDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnMediumPizzaOriginalDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Medium Pizza";
            var mediumPizza = new MediumPizza();
            var extrasDecorator = new ExtrasDecorator(mediumPizza);

            var actualDescription = extrasDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }

        [Test]
        public void ReturnSmallPizzaOriginalCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.0;
            var smallPizza = new SmallPizza();
            var extrasDecorator = new ExtrasDecorator(smallPizza);

            var actualCost = extrasDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaOriginalDescription_WhenGetDescriptionIsCalled()
        {
            var expectedDescription = "Small Pizza";
            var smallPizza = new SmallPizza();
            var extrasDecorator = new ExtrasDecorator(smallPizza);

            var actualDescription = extrasDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}