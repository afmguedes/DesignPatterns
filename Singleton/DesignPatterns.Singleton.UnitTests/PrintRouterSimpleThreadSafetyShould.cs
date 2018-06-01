using System.Threading.Tasks;
using DesignPatterns.Singleton.SimpleThreadSafety;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrintRouterSimpleThreadSafetyShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterSimpleThreadSafety_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrintRouterSimpleThreadSafety.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrintRouterSimpleThreadSafety));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimesInParallel()
        {
            Parallel.For(0, 1000, i =>
            {
                var printRouterSimpleThreadSafety = PrintRouterSimpleThreadSafety.Instance;
            });

            PrintRouterSimpleThreadSafety.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}