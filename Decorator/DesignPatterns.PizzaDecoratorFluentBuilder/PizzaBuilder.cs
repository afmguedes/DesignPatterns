using DesignPatterns.PizzaDecorator;
using DesignPatterns.PizzaDecorator.Components;
using DesignPatterns.PizzaDecorator.ConcreteComponents;
using DesignPatterns.PizzaDecorator.ConcreteDecorators;

namespace DesignPatterns.PizzaDecoratorFluentBuilder
{
    public class PizzaBuilder : IPizzaBuilderSauce, IPizzaBuilderCrust, IPizzaBuilderToppings
    {
        private Pizza pizza;

        public IPizzaBuilderSauce CreatePizzaWithSize(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    pizza = new SmallPizza();
                    break;
                case Size.Medium:
                    pizza = new MediumPizza();
                    break;
                case Size.Large:
                    pizza = new LargePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return this;
        }

        public IPizzaBuilderCrust WithSauce(Sauces sauce)
        {
            pizza = new SauceDecorator(pizza, sauce);
            return this;
        }

        public IPizzaBuilderToppings WithCrust(Crusts crust)
        {
            pizza = new CrustDecorator(pizza, crust);
            return this;
        }

        public IPizzaBuilderToppings AddTopping(Toppings topping)
        {
            pizza = new ToppingDecorator(pizza, topping);
            return this;
        }

        public Pizza Bake()
        {
            return pizza;
        }
    }
}