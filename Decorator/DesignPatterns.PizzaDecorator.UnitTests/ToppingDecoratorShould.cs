using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecorator.UnitTests
{
    [TestFixture]
    public class ToppingDecoratorShould
    {
        [Test]
        public void ReturnSmallPizzaWithOneTierOneToppingCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.25;
            var smallPizza = new SmallPizza();
            var toppingDecorator = new ToppingDecorator(smallPizza, Toppings.BlackOlives);

            var actualCost = toppingDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaWithOneTierTwoToppingCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.5;
            var smallPizza = new SmallPizza();
            var toppingDecorator = new ToppingDecorator(smallPizza, Toppings.Bacon);

            var actualCost = toppingDecorator.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaWithOneToppingDescription_WhenGetDescriptionIsCalled()
        {
            var expectedToppingDescription = Toppings.Bacon;
            var expectedDescription = $"Small Pizza\r\n\t- {expectedToppingDescription}";
            var smallPizza = new SmallPizza();
            var toppingDecorator = new ToppingDecorator(smallPizza, expectedToppingDescription);

            var actualDescription = toppingDecorator.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }

        [Test]
        public void ReturnSmallPizzaWithTwoTierOneToppingsCost_WhenGetCostIsCalled()
        {
            var expectedCost = 5.5;
            var smallPizza = new SmallPizza();
            var toppingDecoratorOne = new ToppingDecorator(smallPizza, Toppings.BlackOlives);
            var toppingDecoratorTwo = new ToppingDecorator(toppingDecoratorOne, Toppings.Mushrooms);

            var actualCost = toppingDecoratorTwo.GetCost();

            actualCost.Should().Be(expectedCost);
        }

        [Test]
        public void ReturnSmallPizzaWithTwoToppingsDescription_WhenGetDescriptionIsCalled()
        {
            var expectedFirstToppingDescription = Toppings.Bacon;
            var expectedSecondToppingDescription = Toppings.Mushrooms;
            var expectedDescription =
                $"Small Pizza\r\n\t- {expectedFirstToppingDescription}\r\n\t- {expectedSecondToppingDescription}";
            var smallPizza = new SmallPizza();
            var toppingDecoratorOne = new ToppingDecorator(smallPizza, expectedFirstToppingDescription);
            var toppingDecoratorTwo = new ToppingDecorator(toppingDecoratorOne, expectedSecondToppingDescription);

            var actualDescription = toppingDecoratorTwo.GetDescription();

            actualDescription.Should().Be(expectedDescription);
        }
    }
}