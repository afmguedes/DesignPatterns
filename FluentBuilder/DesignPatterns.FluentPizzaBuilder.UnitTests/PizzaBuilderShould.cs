using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentPizzaBuilder.UnitTests
{
    [TestFixture]
    public class PizzaBuilderShould
    {
        [Test]
        public void ReturnAPizza_WhenBakeIsCalled()
        {
            var pizzaBuilder = new PizzaBuilder();

            var actualPizza = pizzaBuilder.Bake();

            actualPizza.Should().BeOfType<Pizza>();
        }
    }

    public class Pizza
    {
    }

    public class PizzaBuilder
    {
        public Pizza Bake()
        {
            return new Pizza();
        }
    }
}
