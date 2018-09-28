using System;
using System.Collections.Generic;
using System.Text;
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

    public class ConcreteDecorator : Decorator
    {
        public override string Operation()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.Operation());
            stringBuilder.Append("ConcreteDecorator.Operation();");

            return stringBuilder.ToString();
        }
    }
}
