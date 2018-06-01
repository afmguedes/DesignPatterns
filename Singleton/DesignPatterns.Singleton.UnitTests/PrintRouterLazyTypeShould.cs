using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Singleton.LazyType;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.UnitTests
{
    [TestFixture]
    public class PrintRouterLazyTypeShould
    {
        [Test]
        public void ReturnAnInstanceOfPrintRouterNotFullLazy_WhenIntanceIsRetrieved()
        {
            var printRouterNotThreadSafe = PrintRouterLazyType.Instance;

            printRouterNotThreadSafe.GetType().Should().Be(typeof(PrintRouterLazyType));
        }

        [Test]
        public void OnlyInstanciatedOnce_WhenInstanceIsRetrievedMultipleTimesInParallel()
        {
            Parallel.For(0, 1000, i =>
            {
                var printRouterNotFullLazy = PrintRouterLazyType.Instance;
            });

            PrintRouterLazyType.NumberOfTimesInstanciated.Should().Be(1);
        }
    }
}
