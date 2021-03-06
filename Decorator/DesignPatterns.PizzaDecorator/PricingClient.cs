﻿using System;

namespace DesignPatterns.PizzaDecorator
{
    public static class PricingClient
    {
        public static double GetSizeCost(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return 5.0;
                case Size.Medium:
                    return 6.0;
                case Size.Large:
                    return 7.0;
                default:
                    return 0.0;
            }
        }

        public static double GetCrustCost(Crusts crust)
        {
            var standardCrustCost = 0.0;
            var specialCrustCost = 1.0;

            return crust == Crusts.Stuffed ? specialCrustCost : standardCrustCost;
        }

        public static double GetSauceCost(Sauces sauce)
        {
            var standardSauceCost = 0.25;
            var specialSauceCost = 0.5;

            return sauce == Sauces.Barbecue ? specialSauceCost : standardSauceCost;
        }

        public static double GetToppingCost(Toppings topping)
        {
            var tierOneToppingCost = 0.25;
            var tierTwoToppingCost = 0.5;

            switch (topping)
            {
                case Toppings.BabySpinach:
                case Toppings.BlackOlives:
                case Toppings.GreenPeppers:
                case Toppings.Mushrooms:
                case Toppings.RedOnions:
                case Toppings.RedPeppers:
                case Toppings.SweetCorn:
                case Toppings.Tomatoes:
                    return tierOneToppingCost;
                case Toppings.ChickenStrips:
                case Toppings.Chorizo:
                case Toppings.GroundBeef:
                case Toppings.Ham:
                case Toppings.Mozzarella:
                case Toppings.Pepperoni:
                case Toppings.Pineapple:
                case Toppings.SmokedBacon:
                case Toppings.Tuna:
                    return tierTwoToppingCost;
                default:
                    return 0.0;
            }
        }
    }
}