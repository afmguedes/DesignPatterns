namespace DesignPatterns.CORPizzaRestaurant
{
    public class GeneralManager : Approver
    {
        public override string ApproveOrder(int orderTotal)
        {
            return orderTotal < 2500 ? "Approved by GeneralManager" : "Requires Board Meeting";
        }
    }
}