namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public class ConcreteHandlerOne
    {
        public ConcreteHandlerTwo Successor;

        public void SetSuccessor(ConcreteHandlerTwo concreteHandler)
        {
            Successor = concreteHandler;
        }
    }
}