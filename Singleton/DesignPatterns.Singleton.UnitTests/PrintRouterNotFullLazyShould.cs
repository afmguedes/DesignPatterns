using System.Threading.Tasks;
using DesignPatterns.Singleton.NotFullLazy;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrintRouterNotFullLazyShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterNotFullLazy_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrintRouterNotFullLazy.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrintRouterNotFullLazy));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimesInParallel()
        {
            Parallel.For(0, 1000, i =>
            {
                var printRouterNotFullLazy = PrintRouterNotFullLazy.Instance;
            });

            PrintRouterNotFullLazy.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}