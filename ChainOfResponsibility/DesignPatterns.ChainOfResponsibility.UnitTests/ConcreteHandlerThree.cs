namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public class ConcreteHandlerThree : Handler
    {
        public override int Handle(int requestType)
        {
            return 3;
        }
    }
}