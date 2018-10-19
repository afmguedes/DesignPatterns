using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    [TestFixture]
    public class ConcreteHandlerOneShould
    {
        [Test]
        public void SetHandlerSuccessor_WhenSetSuccessorIsCalled()
        {
            var concreteHandlerOne = new ConcreteHandlerOne();
            var concreteHandlerTwo = new ConcreteHandlerTwo();

            concreteHandlerOne.SetSuccessor(concreteHandlerTwo);

            concreteHandlerOne.Successor.Should().Be(concreteHandlerTwo);
        }

        [Test]
        public void ReturnOneForRequestsOfTypeOne_WhenHandleRequestIsCalled()
        {
            var requestType = 1;
            var expectedConcreteHandlerNumber = 1;
            var concreteHandlerOne = new ConcreteHandlerOne();

            var handledBy = concreteHandlerOne.Handle(requestType);

            handledBy.Should().Be(expectedConcreteHandlerNumber);
        }

        [Test]
        public void ReturnTwoForRequestsOfTypeTwo_WhenHandleRequestIsCalled()
        {
            var requestType = 2;
            var expectedConcreteHandlerNumber = 2;
            var concreteHandlerOne = new ConcreteHandlerOne();
            var concreteHandlerTwo = new ConcreteHandlerTwo();
            concreteHandlerOne.SetSuccessor(concreteHandlerTwo);

            var handledBy = concreteHandlerOne.Handle(requestType);

            handledBy.Should().Be(expectedConcreteHandlerNumber);
        }

        [Test]
        public void ReturnThreeForRequestsOfTypeThree_WhenHandleRequestIsCalled()
        {
            var requestType = 3;
            var expectedConcreteHandlerNumber = 3;
            var concreteHandlerOne = new ConcreteHandlerOne();
            var concreteHandlerTwo = new ConcreteHandlerTwo();
            var concreteHandlerThree = new ConcreteHandlerThree();
            concreteHandlerOne.SetSuccessor(concreteHandlerTwo);
            concreteHandlerTwo.SetSuccessor(concreteHandlerThree);

            var handledBy = concreteHandlerOne.Handle(requestType);

            handledBy.Should().Be(expectedConcreteHandlerNumber);
        }
    }
}