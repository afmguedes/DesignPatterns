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

        public List<Tuple<string, Type>> GetHierarchy()
        {
            var restaurantHierarchy = new List<Tuple<string, Type>>();

            Approver employee = headChef;
            restaurantHierarchy.Add(new Tuple<string, Type>(employee.Name, employee.GetType()));

            while (employee.Supervisor != null)
            {
                employee = employee.Supervisor;
                restaurantHierarchy.Add(new Tuple<string, Type>(employee.Name, employee.GetType()));
            }

            return restaurantHierarchy;
        }

        public List<string> ProcessOrders(int[] orderTotals)
        {
            return orderTotals.Select(orderTotal => headChef.ApproveOrder(orderTotal)).ToList();
        }
    }
}