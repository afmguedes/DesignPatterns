using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.CORPizzaRestaurant.UnitTests
{
    [TestFixture]
    public class PizzaRestaurantShould
    {
        [Test]
        public void ReturnFullRestaurantHierarchy_WhenGetHierarchyIsCalled()
        {
            var expectedHierarchy = new List<Type>
            {
                typeof(HeadChef),
                typeof(KitchenManager),
                typeof(GeneralManager)
            };
            var roberto = new HeadChef();
            var rob = new KitchenManager();
            var yuliya = new GeneralManager();
            var pizzaRestaurant = new PizzaRestaurant(roberto, rob, yuliya);

            var restaurantHierarchy = pizzaRestaurant.GetHierarchy();

            restaurantHierarchy.Should().BeEquivalentTo(expectedHierarchy);
        }

        [Test]
        public void ReturnExpectedApprovals_WhenProcessOrdersIsCalled()
        {
            var expectedApprovals = new List<string>
            {
                "Approved by GeneralManager",
                "Approved by KitchenManager",
                "Requires Board Meeting",
                "Approved by HeadChef"
            };
            var orderTotals = new[] { 1000, 150, 5000, 50 };
            var roberto = new HeadChef();
            var rob = new KitchenManager();
            var yuliya = new GeneralManager();
            var pizzaRestaurant = new PizzaRestaurant(roberto, rob, yuliya);

            var approvals = pizzaRestaurant.ProcessOrders(orderTotals);

            approvals.Should().BeEquivalentTo(expectedApprovals);
        }
    }
}