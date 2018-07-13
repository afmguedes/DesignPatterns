using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentBuilder.UnitTests
{
    [TestFixture]
    public class FluentBuilderShould
    {
        [Test]
        public void ReturnProduct_WhenBuildIsCalled()
        {
            var fluentProductBuilder = new FluentProductBuilder();

            var actualProduct = fluentProductBuilder.Build();

            actualProduct.Should().BeOfType<Product>();
        }

        [Test]
        public void ReturnProductWithPartOne_WhenWithPartOneAndBuildAreCalled()
        {
            var expectedProduct = new Product {PartOne = "PartA"};
            var fluentProductBuilder = new FluentProductBuilder();

            var actualProduct = fluentProductBuilder
                .WithPartOne("PartA")
                .Build();

            actualProduct.Should().BeEquivalentTo(expectedProduct);
        }

        [Test]
        public void ReturnProductWithPartTwo_WhenWithPartTwoAndBuildAreCalled()
        {
            var expectedProduct = new Product {PartTwo = "PartB"};
            var fluentProductBuilder = new FluentProductBuilder();

            var actualProduct = fluentProductBuilder
                .WithPartTwo("PartB")
                .Build();

            actualProduct.Should().BeEquivalentTo(expectedProduct);
        }
    }
}