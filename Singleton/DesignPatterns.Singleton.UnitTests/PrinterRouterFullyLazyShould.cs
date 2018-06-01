using System.Threading.Tasks;
using DesignPatterns.Singleton.FullyLazy;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrinterRouterFullyLazyShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterNotFullLazy_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrinterRouterFullyLazy.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrinterRouterFullyLazy));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimesInParallel()
        {
            Parallel.For(0, 1000, i =>
            {
                var printRouterNotFullLazy = PrinterRouterFullyLazy.Instance;
            });

            PrinterRouterFullyLazy.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}