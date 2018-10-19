using DesignPatterns.ChainOfResponsibility.ConcreteHandlers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    [TestFixture]
    public class ConcreteHandlerTwoShould
    {
        [Test]
        public void SetHandlerSuccessor_WhenSetSuccessorIsCalled()
        {
            var concreteHandlerTwo = new ConcreteHandlerTwo();
            var concreteHandlerThree = new ConcreteHandlerThree();

            concreteHandlerTwo.SetSuccessor(concreteHandlerThree);

            concreteHandlerTwo.Successor.Should().Be(concreteHandlerThree);
        }

        [Test]
        public void ReturnMinusOneIfSuccessorIsNotSet_WhenHandleRequestIsCalled()
        {
            var requestType = 3;
            var expectedConcreteHandlerNumber = -1;
            var concreteHandlerTwo = new ConcreteHandlerTwo();

            var handledBy = concreteHandlerTwo.Handle(requestType);

            handledBy.Should().Be(expectedConcreteHandlerNumber);
        }
    }
}