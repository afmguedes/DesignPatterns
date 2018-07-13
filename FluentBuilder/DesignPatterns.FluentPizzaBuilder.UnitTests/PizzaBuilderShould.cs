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

        [Test]
        public void ReturnAPizzaWithSize_WhenWithSizeIsCalled()
        {
            var expectedPizza = new Pizza {Size = Size.Large};
            var pizzaBuilder = new PizzaBuilder();

            var actualPizza = pizzaBuilder
                .WithSize(Size.Large)
                .Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void ReturnAPizzaWithSizeAndCrust_WhenWithSizeAndWithCrustCalled()
        {
            var expectedPizza = new Pizza { Size = Size.Large, Crust = CrustType.Stuffed };
            var pizzaBuilder = new PizzaBuilder();

            var actualPizza = pizzaBuilder
                .WithSize(Size.Large)
                .WithCrust(CrustType.Stuffed)
                .Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }
    }

    public class Pizza
    {
        public Size Size { get; set; }
        public CrustType Crust { get; set; }
    }

    public enum CrustType
    {
        Classic,
        Stuffed,
        Thin
    }

    public enum Size
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder WithSize(Size size)
        {
            pizza.Size = size;
            return this;
        }

        public PizzaBuilder WithCrust(CrustType typeOfCrust)
        {
            pizza.Crust = typeOfCrust;
            return this;
        }

        public Pizza Bake()
        {
            return pizza;
        }
    }
}
