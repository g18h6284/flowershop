using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            anOrderDAO = Substitute.For<IOrderDAO>();
            aClient = Substitute.For<IClient>();
            anOrder = new Order(anOrderDAO, aClient);
            //ACT
            anOrder.Deliver();
            //ASSERT
            anOrderDAO.Recieved().SetDelivered();
            anOrderDAO.NotRecieved().SetDelivered();
            Assert.That();
        }
    }
}