namespace DesignPatterns.CORPizzaRestaurant
{
    public abstract class Approver
    {
        public string Name;
        public Approver Supervisor;

        protected Approver(string name)
        {
            Name = name;
        }

        public void SetSupervisor(Approver approver)
        {
            Supervisor = approver;
        }

        public abstract string ApproveOrder(int orderTotal);
    }
}