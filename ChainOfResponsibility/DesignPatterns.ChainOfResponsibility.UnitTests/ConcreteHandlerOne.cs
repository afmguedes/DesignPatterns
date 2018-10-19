namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public class ConcreteHandlerOne : Handler
    {
        public override int Handle(int requestType)
        {
            if (requestType == 1)
            {
                return 1;
            }

            return Successor.Handle(requestType);
        }
    }
}