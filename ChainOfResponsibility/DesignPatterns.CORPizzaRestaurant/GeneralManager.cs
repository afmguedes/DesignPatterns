namespace DesignPatterns.CORPizzaRestaurant
{
    public class GeneralManager : Approver
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 2500 ? $"Approved by {Name}" : "Requires Board Meeting";
        }
    }
}