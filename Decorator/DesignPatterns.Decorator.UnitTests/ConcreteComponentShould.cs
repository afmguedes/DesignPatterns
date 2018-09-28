using System;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Decorator.UnitTests
{
    [TestFixture]
    public class ConcreteComponentShould
    {
        [Test]
        public void ReturnOverridenOperation_WhenOperationIsCalled()
        {
            var expectedOperationResult = "ConcreteComponent.Operation()";
            var concreteComponent = new ConcreteComponent();

            var operationResult = concreteComponent.Operation();

            operationResult.Should().Be(expectedOperationResult);
        }
    }
}
