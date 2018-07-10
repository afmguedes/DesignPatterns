using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Builder.UnitTests
{
    [TestFixture]
    public class ConcreteBuilderAbShould
    {
        [Test]
        public void ReturnAProduct_WhenBuildIsCalled()
        {
            var concreteBuilderAb = new ConcreteBuilderAb();

            var actual = concreteBuilderAb.Build();

            actual.Should().BeOfType<Product>();
        }

        [Test]
        public void ReturnAProductWithAPartOne_WhenBuildIsCalled()
        {
            var expectedProduct = new Product();
            expectedProduct.Add("Part A");

            var concreteBuilderAb = new ConcreteBuilderAb();

            concreteBuilderAb.IncludePartOne();
            var actual = concreteBuilderAb.Build();

            actual.Should().BeEquivalentTo(expectedProduct);
        }

        [Test]
        public void ReturnAProductWithAPartTwo_WhenBuildIsCalled()
        {
            var expectedProduct = new Product();
            expectedProduct.Add("Part B");

            var concreteBuilderAb = new ConcreteBuilderAb();

            concreteBuilderAb.IncludePartTwo();
            var actual = concreteBuilderAb.Build();

            actual.Should().BeEquivalentTo(expectedProduct);
        }
    }
}