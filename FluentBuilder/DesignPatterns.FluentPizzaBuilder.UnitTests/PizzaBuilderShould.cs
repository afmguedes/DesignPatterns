using System.Collections.Generic;
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
            var customPizza = new PizzaBuilder();

            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeOfType<Pizza>();
        }

        [Test]
        public void ReturnExpectedPizza_WhenCreatePizzaWithSizeIsCalled()
        {
            var expectedPizza = new Pizza {Size = Size.Large};
            var customPizza = new PizzaBuilder();

	        customPizza.CreatePizzaWithSize(Size.Large);
	        var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void ReturnExpectedPizza_WhenCreatePizzaWithSizeAndWithCrustCalled()
        {
            var expectedPizza = new Pizza { Size = Size.Large, Crust = Crusts.Stuffed };
            var customPizza = new PizzaBuilder();

	        customPizza.CreatePizzaWithSize(Size.Large)
		        .WithCrust(Crusts.Stuffed);
	        var actualPizza = customPizza.Bake();

			actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

	    [Test]
	    public void ReturnExpectedPizza_WhenCreatePizzaWithSizeAndWithCrustAndWithSauceCalled()
		{
		    var expectedPizza = new Pizza { Size = Size.Large, Crust = Crusts.Stuffed, Sauce = Sauces.Tomato };
		    var customPizza = new PizzaBuilder();

		    customPizza.CreatePizzaWithSize(Size.Large)
			    .WithCrust(Crusts.Stuffed)
				.WithSauce(Sauces.Tomato);
		    var actualPizza = customPizza.Bake();

		    actualPizza.Should().BeEquivalentTo(expectedPizza);
	    }

	    [Test]
	    public void ReturnExpectedPizza_WhenCreatePizzaWithSizeAndWithCrustAndWithSauceAndAddToppingCalled()
		{
		    var expectedPizza = new Pizza { Size = Size.Large, Crust = Crusts.Stuffed, Sauce = Sauces.Tomato, Toppings = new List<Toppings> {Toppings.Mushrooms} };
		    var customPizza = new PizzaBuilder();

		    customPizza.CreatePizzaWithSize(Size.Large)
			    .WithCrust(Crusts.Stuffed)
			    .WithSauce(Sauces.Tomato)
				.AddTopping(Toppings.Mushrooms);
		    var actualPizza = customPizza.Bake();

		    actualPizza.Should().BeEquivalentTo(expectedPizza);
	    }

	    [Test]
	    public void ReturnExpectedPizza_WhenCreatePizzaWithSizeAndWithCrustAndWithSauceAndAddToppingTwiceCalled()
		{
		    var expectedPizza = new Pizza { Size = Size.Large, Crust = Crusts.Stuffed, Sauce = Sauces.Tomato, Toppings = new List<Toppings> { Toppings.Mushrooms, Toppings.Ham } };
		    var customPizza = new PizzaBuilder();

		    customPizza.CreatePizzaWithSize(Size.Large)
			    .WithCrust(Crusts.Stuffed)
			    .WithSauce(Sauces.Tomato)
			    .AddTopping(Toppings.Mushrooms)
			    .AddTopping(Toppings.Ham);
			var actualPizza = customPizza.Bake();

		    actualPizza.Should().BeEquivalentTo(expectedPizza);
	    }
	}
}