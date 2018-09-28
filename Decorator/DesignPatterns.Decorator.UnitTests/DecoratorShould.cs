using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Decorator.UnitTests
{
    [TestFixture]
    public class DecoratorShould
    {
        [Test]
        public void ReturnOriginalOperation_WhenOverridenOperationIsCalled()
        {
            var expectedOperationResult = "Component.Operation();";
            var component = new Component();
            var decorator = new Decorator();
            decorator.SetComponent(component);

            var operationResult = decorator.Operation();

            operationResult.Should().Be(expectedOperationResult);
        }
    }
}