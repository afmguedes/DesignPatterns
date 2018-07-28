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
        public void ReturnExpectedPizza_WhenWithSizeIsCalled()
        {
            var expectedPizza = new Pizza {Size = Size.Large};
            var customPizza = new PizzaBuilder();

	        customPizza.WithSize(Size.Large);
	        var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void ReturnExpectedPizza_WhenWithSizeAndWithCrustCalled()
        {
            var expectedPizza = new Pizza { Size = Size.Large, Crust = CrustType.Stuffed };
            var customPizza = new PizzaBuilder();

	        customPizza.WithSize(Size.Large)
		        .WithCrust(CrustType.Stuffed);
	        var actualPizza = customPizza.Bake();

			actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

	    [Test]
	    public void ReturnExpectedPizza_WhenWithSizeAndWithCrustAndWithSauceCalled() {
		    var expectedPizza = new Pizza { Size = Size.Large, Crust = CrustType.Stuffed, SauceType = SauceType.Tomato };
		    var customPizza = new PizzaBuilder();

		    customPizza.WithSize(Size.Large)
			    .WithCrust(CrustType.Stuffed)
				.WithSauce(SauceType.Tomato);
		    var actualPizza = customPizza.Bake();

		    actualPizza.Should().BeEquivalentTo(expectedPizza);
	    }

	    [Test]
	    public void ReturnExpectedPizza_WhenWithSizeAndWithCrustAndWithSauceAndAddToppingCalled() {
		    var expectedPizza = new Pizza { Size = Size.Large, Crust = CrustType.Stuffed, SauceType = SauceType.Tomato, Toppings = new List<Toppings> {Toppings.Mushrooms} };
		    var customPizza = new PizzaBuilder();

		    customPizza.WithSize(Size.Large)
			    .WithCrust(CrustType.Stuffed)
			    .WithSauce(SauceType.Tomato)
				.AddTopping(Toppings.Mushrooms);
		    var actualPizza = customPizza.Bake();

		    actualPizza.Should().BeEquivalentTo(expectedPizza);
	    }
	}
}
