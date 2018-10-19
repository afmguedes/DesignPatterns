using System.Collections.Generic;
using DesignPatterns.ChainOfResponsibility.Clients;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    [TestFixture]
    public class ClientShould
    {
        [Test]
        public void ReturnExpectedListOfHandlers_WhenProcessRequestsIsCalled()
        {
            var client = new Client();
            var requestTypes = new List<int> {1, 2, 3};
            var expectedHandlers = new List<int> {1, 2, 3};

            var actualHandlers = client.ProcessRequests(requestTypes);

            actualHandlers.Should().BeEquivalentTo(expectedHandlers);
        }
    }
}