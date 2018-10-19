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
    }
}