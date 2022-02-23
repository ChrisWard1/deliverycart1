using Xunit;
using DeliveryCartTest.Services;

namespace DeliveryCartTest.UnitTests.Services
{
    public class DeliveryCartTest_IsDeliveryShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var deliveryCartTest = new DeliveryCartTest1();
            bool result = deliveryCartTest.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}