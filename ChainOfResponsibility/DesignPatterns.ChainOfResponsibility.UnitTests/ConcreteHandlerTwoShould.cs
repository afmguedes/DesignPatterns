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
    }
}