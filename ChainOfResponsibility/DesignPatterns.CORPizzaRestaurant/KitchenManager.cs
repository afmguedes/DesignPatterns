namespace DesignPatterns.CORPizzaRestaurant
{
    public class KitchenManager : Approver
    {
        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 500 ? "Approved by KitchenManager" : Supervisor.ApproveOrder(orderTotal);
        }
    }
}