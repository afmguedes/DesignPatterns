namespace DesignPatterns.CORPizzaRestaurant
{
    public class KitchenManager : Approver
    {
        public KitchenManager(string name) : base(name)
        {
        }

        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 500 ? $"Approved by {Name}" : Supervisor.ApproveOrder(orderTotal);
        }
    }
}