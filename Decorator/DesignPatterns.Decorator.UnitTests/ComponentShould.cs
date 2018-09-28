using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Decorator.UnitTests
{
    [TestFixture]
    public class ComponentShould
    {
        [Test]
        public void ReturnOperationResult_WhenOperationIsCalled()
        {
            var expectedOperationResult = "Component.Operation();";
            var component = new Component();

            var operationResult = component.Operation();

            operationResult.Should().Be(expectedOperationResult);
        }
    }
}