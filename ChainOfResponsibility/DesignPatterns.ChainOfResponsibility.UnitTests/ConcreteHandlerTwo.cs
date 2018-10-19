namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public class ConcreteHandlerTwo
    {
        public ConcreteHandlerThree Successor;

        public void SetSuccessor(ConcreteHandlerThree concreteHandler)
        {
            Successor = concreteHandler;
        }
    }
}