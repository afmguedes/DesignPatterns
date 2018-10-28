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
            var expectedHeadChef = "Adrian";
            var expectedKitchenManager = "David";
            var expectedGeneralManager = "Yuliya";
            var expectedHierarchy = new List<Tuple<string, Type>>
            {
                new Tuple<string, Type>(expectedHeadChef, typeof(HeadChef)),
                new Tuple<string, Type>(expectedKitchenManager, typeof(KitchenManager)),
                new Tuple<string, Type>(expectedGeneralManager, typeof(GeneralManager))
            };
            var headChef = new HeadChef(expectedHeadChef);
            var kitchenManager = new KitchenManager(expectedKitchenManager);
            var generalManager = new GeneralManager(expectedGeneralManager);
            var pizzaRestaurant = new PizzaRestaurant(headChef, kitchenManager, generalManager);

            var restaurantHierarchy = pizzaRestaurant.GetHierarchy();

            restaurantHierarchy.Should().BeEquivalentTo(expectedHierarchy);
        }

        [Test]
        public void ReturnExpectedApprovals_WhenProcessOrdersIsCalled()
        {
            var expectedApprovals = new List<string>
            {
                "Approved by Rob",
                "Approved by John",
                "Requires Board Meeting",
                "Approved by Roberto"
            };
            var orderTotals = new[] { 1000, 150, 5000, 50 };
            var headChef = new HeadChef("Roberto");
            var kitchenManager = new KitchenManager("John");
            var generalManager = new GeneralManager("Rob");
            var pizzaRestaurant = new PizzaRestaurant(headChef, kitchenManager, generalManager);

            var approvals = pizzaRestaurant.ProcessOrders(orderTotals);

            approvals.Should().BeEquivalentTo(expectedApprovals);
        }
    }
}