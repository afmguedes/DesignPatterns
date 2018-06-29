using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentBuilder.UnitTests
{
    [TestFixture]
    public class ConcreteBuilderAbcShould
    {
        [Test]
        public void ReturnAProduct_WhenBuildIsCalled()
        {
            var concreteBuilderAbc = new ConcreteBuilderAbc();

            var actual = concreteBuilderAbc.Build();

            actual.Should().BeOfType<Product>();
        }
    }
}