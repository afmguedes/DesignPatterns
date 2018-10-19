namespace DesignPatterns.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerThree : Handler.Handler
    {
        public override int Handle(int requestType)
        {
            return 3;
        }
    }
}