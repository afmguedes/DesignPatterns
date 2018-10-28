using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.CORPizzaRestaurant.UnitTests
{
    [TestFixture]
    public class HeadChefShould
    {
        [Test]
        public void SetSupervisor_WhenSetSupervisorIsCalled()
        {
            var headChef = new HeadChef("Roberto");
            var kitchenManager = new KitchenManager("Rob");

            headChef.SetSupervisor(kitchenManager);

            headChef.Supervisor.Should().Be(kitchenManager);
        }

        [Test]
        public void ReturnApprovedByHeadChef_WhenApproveOrderIsCalledWithTotalLessThan100()
        {
            var expectedApprover = "David";
            var expectedApproval = $"Approved by {expectedApprover}";
            var orderTotal = 99;
            var headChef = new HeadChef(expectedApprover);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }

        [Test]
        public void ReturnApprovedByKitchenManager_WhenApproveOrderIsCalledWithTotalBetween100And499()
        {
            var expectedApprover = "Adrian";
            var expectedApproval = $"Approved by {expectedApprover}";
            var orderTotal = 499;
            var headChef = new HeadChef("John");
            var kitchenMannager = new KitchenManager(expectedApprover);
            headChef.SetSupervisor(kitchenMannager);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }

        [Test]
        public void ReturnApprovedByGeneralManager_WhenApproveOrderIsCalledWithTotalBetween500And2499()
        {
            var expectedApprover = "Yuliya";
            var expectedApproval = $"Approved by {expectedApprover}";
            var orderTotal = 2499;
            var headChef = new HeadChef("Arun");
            var kitchenMannager = new KitchenManager("Thiago");
            var generalManager = new GeneralManager(expectedApprover);
            headChef.SetSupervisor(kitchenMannager);
            kitchenMannager.SetSupervisor(generalManager);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }

        [Test]
        public void ReturnRequiresBoardMeeting_WHenApproveOrderIsCalledWithTotalGreaterOrEqualThan2500()
        {
            var expectedApproval = "Requires Board Meeting";
            var orderTotal = 2500;
            var headChef = new HeadChef("Jonathan");
            var kitchenMannager = new KitchenManager("Charlie");
            var generalManager = new GeneralManager("Nick");
            headChef.SetSupervisor(kitchenMannager);
            kitchenMannager.SetSupervisor(generalManager);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }
    }
}
