namespace DesignPatterns.CORPizzaRestaurant
{
    public abstract class Approver
    {
        public Approver Supervisor;

        public void SetSupervisor(Approver approver)
        {
            Supervisor = approver;
        }

        public abstract string ApproveOrder(int orderTotal);
    }
}