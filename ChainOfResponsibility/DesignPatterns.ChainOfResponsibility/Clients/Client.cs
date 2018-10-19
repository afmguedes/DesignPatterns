using System.Collections.Generic;
using DesignPatterns.ChainOfResponsibility.ConcreteHandlers;
using DesignPatterns.ChainOfResponsibility.UnitTests;

namespace DesignPatterns.ChainOfResponsibility.Clients
{
    public class Client
    {
        public List<int> ProcessRequests(List<int> requestTypes)
        {
            var handlers = new List<int>();
            var concreteHandlerOne = new ConcreteHandlerOne();
            var concreteHandlerTwo = new ConcreteHandlerTwo();
            var concreteHandlerThree = new ConcreteHandlerThree();

            concreteHandlerOne.SetSuccessor(concreteHandlerTwo);
            concreteHandlerTwo.SetSuccessor(concreteHandlerThree);

            foreach (var requestType in requestTypes)
            {
                handlers.Add(concreteHandlerOne.Handle(requestType));
            }

            return handlers;
        }
    }
}