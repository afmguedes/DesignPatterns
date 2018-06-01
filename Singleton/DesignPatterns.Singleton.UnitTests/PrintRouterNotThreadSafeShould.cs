using DesignPatterns.Singleton.NotThreadSafe;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrintRouterNotThreadSafeShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterNotThreadSafe_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrintRouterNotThreadSafe.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrintRouterNotThreadSafe));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimes()
        {
            for (var iteration = 0; iteration < 1000; iteration++)
            {
                var printRouterNotThreadSafe = PrintRouterNotThreadSafe.Instance;
            }

            PrintRouterNotThreadSafe.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}