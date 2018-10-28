namespace DesignPatterns.CORPizzaRestaurant
{
    public class HeadChef : Approver
    {
        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 100 ? "Approved by HeadChef" : Supervisor.ApproveOrder(orderTotal);
        }
    }
}