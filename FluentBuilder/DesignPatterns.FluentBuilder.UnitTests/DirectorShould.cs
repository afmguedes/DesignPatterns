using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentBuilder.UnitTests
{
    [TestFixture]
    public class DirectorShould
    {
        [Test]
        public void ConstructABuilderWithPartOneAndTwo_WhenConstructIsCalledWithConcreteBuilderAb()
        {
            var expectedBuilder = new ConcreteBuilderAb();
            expectedBuilder.IncludePartOne();
            expectedBuilder.IncludePartTwo();

            var director = new Director();
            var builder = new ConcreteBuilderAb();

            director.Construct(builder);

            builder.Should().BeEquivalentTo(expectedBuilder);
        }

        [Test]
        public void ConstructABuilderWithPartOneAndTwo_WhenConstructIsCalledWithConcreteBuilderCd()
        {
            var expectedBuilder = new ConcreteBuilderCd();
            expectedBuilder.IncludePartOne();
            expectedBuilder.IncludePartTwo();

            var director = new Director();
            var builder = new ConcreteBuilderCd();

            director.Construct(builder);

            builder.Should().BeEquivalentTo(expectedBuilder);
        }
    }
}