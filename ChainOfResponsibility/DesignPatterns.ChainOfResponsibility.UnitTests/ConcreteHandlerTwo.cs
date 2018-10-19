namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public class ConcreteHandlerTwo : Handler
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