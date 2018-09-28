using System.Text;

namespace DesignPatterns.Decorator.UnitTests
{
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