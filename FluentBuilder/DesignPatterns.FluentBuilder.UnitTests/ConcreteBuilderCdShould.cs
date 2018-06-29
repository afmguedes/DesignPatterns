using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentBuilder.UnitTests
{
    [TestFixture]
    public class ConcreteBuilderCdShould
    {
        [Test]
        public void ReturnAProduct_WhenBuildIsCalled()
        {
            var concreteBuilderCd = new ConcreteBuilderCd();

            var actual = concreteBuilderCd.Build();

            actual.Should().BeOfType<Product>();
        }

        [Test]
        public void ReturnAProductWithAPartOne_WhenBuildIsCalled()
        {
            var expectedProduct = new Product();
            expectedProduct.Add("Part C");

            var concreteBuilderCd = new ConcreteBuilderCd();

            concreteBuilderCd.IncludePartOne();
            var actual = concreteBuilderCd.Build();

            actual.Should().BeEquivalentTo(expectedProduct);
        }

        [Test]
        public void ReturnAProductWithAPartTwo_WhenBuildIsCalled()
        {
            var expectedProduct = new Product();
            expectedProduct.Add("Part D");

            var concreteBuilderCd = new ConcreteBuilderCd();

            concreteBuilderCd.IncludePartTwo();
            var actual = concreteBuilderCd.Build();

            actual.Should().BeEquivalentTo(expectedProduct);
        }
    }
}