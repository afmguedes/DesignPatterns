namespace DesignPatterns.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerTwo : Handler.Handler
    {
        public override int Handle(int requestType)
        {
            if (requestType == 2)
            {
                return 2;
            }

            return Successor.Handle(requestType);
        }
    }
}