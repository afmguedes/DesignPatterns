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
            var headChef = new HeadChef();
            var kitchenManager = new KitchenManager();

            headChef.SetSupervisor(kitchenManager);

            headChef.Supervisor.Should().Be(kitchenManager);
        }

        [Test]
        public void ReturnApprovedByHeadChef_WhenApproveOrderIsCalledWithTotalLessThan100()
        {
            var expectedApproval = "Approved by HeadChef";
            var orderTotal = 99;
            var headChef = new HeadChef();

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }

        [Test]
        public void ReturnApprovedByKitchenManager_WhenApproveOrderIsCalledWithTotalBetween100And499()
        {
            var expectedApproval = "Approved by KitchenManager";
            var orderTotal = 499;
            var headChef = new HeadChef();
            var kitchenMannager = new KitchenManager();
            headChef.SetSupervisor(kitchenMannager);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }

        [Test]
        public void ReturnApprovedByGeneralManager_WhenApproveOrderIsCalledWithTotalBetween500And2499()
        {
            var expectedApproval = "Approved by GeneralManager";
            var orderTotal = 2499;
            var headChef = new HeadChef();
            var kitchenMannager = new KitchenManager();
            var generalManager = new GeneralManager();
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
            var headChef = new HeadChef();
            var kitchenMannager = new KitchenManager();
            var generalManager = new GeneralManager();
            headChef.SetSupervisor(kitchenMannager);
            kitchenMannager.SetSupervisor(generalManager);

            var approval = headChef.ApproveOrder(orderTotal);

            approval.Should().Be(expectedApproval);
        }
    }
}
