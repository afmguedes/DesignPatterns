using System.Collections.Generic;

namespace DesignPatterns.PizzaDecorator.Components
{
    public abstract class Pizza
    {
        public Size Size;
        public Sauces Sauce;
        public Crusts Crust;
        public List<Toppings> Toppings = new List<Toppings>();

        public abstract double GetCost();

        public abstract string GetDescription();
    }
}