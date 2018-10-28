namespace DesignPatterns.CORPizzaRestaurant
{
    public class HeadChef : Approver
    {
        public HeadChef(string name) : base(name)
        {
        }

        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 100 ? $"Approved by {Name}" : Supervisor.ApproveOrder(orderTotal);
        }
    }
}