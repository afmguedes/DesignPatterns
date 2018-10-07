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
        public void CreateSmallPizzaWithSauceAndCrust_WhenWithCrustIsCalled()
        {
            var sauce = Sauces.Tomato;
            var crust = Crusts.Classic;
            var smallPizza = new SmallPizza();
            var smallPizzaWithSauce = new SauceDecorator(smallPizza, sauce);
            var expectedPizza = new CrustDecorator(smallPizzaWithSauce, crust);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithSauce(sauce)
                .WithCrust(crust);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithOneTopping_WhenWithToppingIsCalledOnce()
        {
            var sauce = Sauces.Tomato;
            var crust = Crusts.Classic;
            var topping = Toppings.Cheese;
            var smallPizza = new SmallPizza();
            var smallPizzaWithSauce = new SauceDecorator(smallPizza, sauce);
            var smallPizzaWithSauceAndCrust = new CrustDecorator(smallPizzaWithSauce, crust);
            var expectedPizza = new ToppingDecorator(smallPizzaWithSauceAndCrust, topping);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithSauce(sauce)
                .WithCrust(crust)
                .AddTopping(topping);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }

        [Test]
        public void CreateSmallPizzaWithTwoTopping_WhenWithToppingIsCalledTwice()
        {
            var sauce = Sauces.Tomato;
            var crust = Crusts.Classic;
            var toppingOne = Toppings.Cheese;
            var toppingTwo = Toppings.Ham;
            var smallPizza = new SmallPizza();
            var smallPizzaWithSauce = new SauceDecorator(smallPizza, sauce);
            var smallPizzaWithSauceAndCrust = new CrustDecorator(smallPizzaWithSauce, crust);
            var smallPizzaWithSauceCrustAndOneTopping = new ToppingDecorator(smallPizzaWithSauceAndCrust, toppingOne);
            var expectedPizza = new ToppingDecorator(smallPizzaWithSauceCrustAndOneTopping, toppingTwo);
            var customPizza = new PizzaBuilder();

            customPizza.CreatePizzaWithSize(Size.Small)
                .WithSauce(sauce)
                .WithCrust(crust)
                .AddTopping(toppingOne)
                .AddTopping(toppingTwo);
            var actualPizza = customPizza.Bake();

            actualPizza.Should().BeEquivalentTo(expectedPizza);
        }
    }
}