using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.CORPizzaRestaurant
{
    public class PizzaRestaurant
    {
        private readonly HeadChef headChef;

        public PizzaRestaurant(HeadChef headChef, KitchenManager kitchenManager, GeneralManager generalManager)
        {
            this.headChef = headChef;
            kitchenManager.Supervisor = generalManager;
            this.headChef.Supervisor = kitchenManager;
        }

        public List<Type> GetHierarchy()
        {
            var restaurantHierarchy = new List<Type>();

            Approver employee = headChef;
            restaurantHierarchy.Add(employee.GetType());

            while (employee.Supervisor != null)
            {
                employee = employee.Supervisor;
                restaurantHierarchy.Add(employee.GetType());
            }

            return restaurantHierarchy;
        }

        public List<string> ProcessOrders(int[] orderTotals)
        {
            return orderTotals.Select(orderTotal => headChef.ApproveOrder(orderTotal)).ToList();
        }
    }
}