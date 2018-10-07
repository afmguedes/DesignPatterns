using System;
using DesignPatterns.PizzaDecorator;
using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.PizzaDecoratorFluentBuilder.UnitTests
{
    [TestFixture]
    public class PizzaBuilderShould
    {
        [Test]
        public void CreateSmallPizza_WhenCreatePizzaWithSizeSmallIsCalled()
        {
            var expectedPizza = new SmallPizza();
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateMediumPizza_WhenCreatePizzaWithSizeMediumIsCalled()
        {
            var expectedPizza = new MediumPizza();
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Medium);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateLargePizza_WhenCreatePizzaWithSizeLargeIsCalled()
        {
            var expectedPizza = new LargePizza();
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Large);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithSauce_WhenWithSauceIsCalled()
        {
            var sauce = Sauces.Tomato;
            var smallPizza = new SmallPizza();
            var expectedPizza = new SauceDecorator(smallPizza, sauce);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithSauce(sauce);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithCrust_WhenWithCrustIsCalled()
        {
            var crust = Crusts.Classic;
            var smallPizza = new SmallPizza();
            var expectedPizza = new CrustDecorator(smallPizza, crust);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithCrust(crust);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithOneTopping_WhenWithToppingIsCalledOnce()
        {
            var topping = Toppings.Cheese;
            var smallPizza = new SmallPizza();
            var expectedPizza = new ToppingDecorator(smallPizza, topping);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithTopping(topping);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithTwoTopping_WhenWithToppingIsCalledTwice()
        {
            var toppingOne = Toppings.Cheese;
            var toppingTwo = Toppings.Ham;
            var smallPizza = new SmallPizza();
            var smallPizzaWithOneTopping = new ToppingDecorator(smallPizza, toppingOne);
            var expectedPizza = new ToppingDecorator(smallPizzaWithOneTopping, toppingTwo);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithTopping(toppingOne)
                .WithTopping(toppingTwo);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithAllProperties_WhenBakeIsCalled()
        {
            var size = Size.Medium;
            var sauce = Sauces.Tomato;
            var crust = Crusts.Classic;
            var toppingOne = Toppings.Cheese;
            var toppingTwo = Toppings.Ham;

            var smallPizza = new MediumPizza();
            var smallPizzaWithSauce = new SauceDecorator(smallPizza, sauce);
            var smallPizzaWithSauceAndCrust = new CrustDecorator(smallPizzaWithSauce, crust);
            var smallPizzaWithSauceCrustAndOneTopping = new ToppingDecorator(smallPizzaWithSauceAndCrust, toppingOne);
            var expectedPizza = new ToppingDecorator(smallPizzaWithSauceCrustAndOneTopping, toppingTwo);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(size)
                .WithSauce(sauce)
                .WithCrust(crust)
                .WithTopping(toppingOne)
                .WithTopping(toppingTwo);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }
    }
}