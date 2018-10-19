using DesignPatterns.ChainOfResponsibility.Handlers;

namespace DesignPatterns.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerThree : Handler
    {
        public override int Handle(int requestType)
        {
            return 3;
        }
    }
}