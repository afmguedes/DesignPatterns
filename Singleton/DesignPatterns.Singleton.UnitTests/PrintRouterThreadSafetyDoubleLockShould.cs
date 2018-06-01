using System.Threading.Tasks;
using DesignPatterns.Singleton.ThreadSafetyDoubleLock;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrintRouterThreadSafetyDoubleLockShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterThreadSafetyDoubleLock_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrintRouterThreadSafetyDoubleLock.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrintRouterThreadSafetyDoubleLock));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimesInParallel()
        {
            Parallel.For(0, 1000, i =>
            {
                var printRouterThreadSafetyDoubleLock = PrintRouterThreadSafetyDoubleLock.Instance;
            });

            PrintRouterThreadSafetyDoubleLock.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}