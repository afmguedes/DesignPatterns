using DesignPatterns.ChainOfResponsibility.Handlers;

namespace DesignPatterns.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerTwo : Handler
    {
        public override int Handle(int requestType)
        {
            if (requestType == 2)
            {
                return 2;
            }

            if (Successor != null)
            {
                return Successor.Handle(requestType);
            }

            return -1;
        }
    }
}