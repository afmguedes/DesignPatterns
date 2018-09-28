using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Decorator.UnitTests
{
    [TestFixture]
    public class ConcreteDecoratorShould
    {
        [Test]
        public void ReturnBothOperationResults_WhenOperationIsCalled()
        {
            var expectedOperationResult = "Component.Operation();\r\nConcreteDecorator.Operation();";
            var component = new Component();
            var concreteDecorator = new ConcreteDecorator();
            concreteDecorator.SetComponent(component);

            var operationResult = concreteDecorator.Operation();

            operationResult.Should().Be(expectedOperationResult);
        }
    }
}