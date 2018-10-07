using DesignPatterns.FluentPizzaBuilder.Builders;
using DesignPatterns.FluentPizzaBuilder.Enums;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentPizzaBuilder.UnitTests
{
    [TestFixture]
    public class PizzaShould
    {
        [Test]
        public void ReturnStringContainingPizzaSize_WhenToStringIsCalled()
        {
            var expectedString = "Medium Pizza";
            var pizzaiolo = new PizzaBuilder();
            pizzaiolo.CreatePizzaWithSize(Size.Medium);
            var pizza = pizzaiolo.Bake();

            var result = pizza.ToString();

            result.Should().Contain(expectedString);
        }

        [Test]
        public void ReturnStringContainingPizzaSizeAndCrust_WhenToStringIsCalled()
        {
            var expectedString = "Medium Pizza with Classic Crust";
            var pizzaiolo = new PizzaBuilder();
            pizzaiolo.CreatePizzaWithSize(Size.Medium)
                .WithCrust(Crusts.Classic);
            var pizza = pizzaiolo.Bake();

            var result = pizza.ToString();

            result.Should().Contain(expectedString);
        }

        [Test]
        public void ReturnStringContainingPizzaSizeCrustAndSauce_WhenToStringIsCalled()
        {
            var expectedString = "Medium Pizza with Classic Crust, Tomato Sauce";
            var pizzaiolo = new PizzaBuilder();
            pizzaiolo.CreatePizzaWithSize(Size.Medium)
                .WithCrust(Crusts.Classic)
                .WithSauce(Sauces.Tomato);
            var pizza = pizzaiolo.Bake();

            var result = pizza.ToString();

            result.Should().Contain(expectedString);
        }

        [Test]
        public void ReturnStringContainingPizzaSizeCrustSauceAndMoreThanOneTopping_WhenToStringIsCalled()
        {
            var expectedString = "Medium Pizza with Classic Crust, Tomato Sauce and:\r\nHam\r\nMushrooms\r\nMozzarella";
            var pizzaiolo = new PizzaBuilder();
            pizzaiolo.CreatePizzaWithSize(Size.Medium)
                .WithCrust(Crusts.Classic)
                .WithSauce(Sauces.Tomato)
                .AddTopping(Toppings.Ham)
                .AddTopping(Toppings.Mushrooms)
                .AddTopping(Toppings.Mozzarella);
            var pizza = pizzaiolo.Bake();

            var result = pizza.ToString();

            result.Should().Contain(expectedString);
        }

        [Test]
        public void ReturnStringContainingPizzaSizeCrustSauceAndOneTopping_WhenToStringIsCalled()
        {
            var expectedString = "Medium Pizza with Classic Crust, Tomato Sauce and:\r\nHam";
            var pizzaiolo = new PizzaBuilder();
            pizzaiolo.CreatePizzaWithSize(Size.Medium)
                .WithCrust(Crusts.Classic)
                .WithSauce(Sauces.Tomato)
                .AddTopping(Toppings.Ham);
            var pizza = pizzaiolo.Bake();

            var result = pizza.ToString();

            result.Should().Contain(expectedString);
        }
    }
}