using Moq;
using MyDriver;
using MyWork;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class MyClientTestFixture
    {
        [Test]
        public void OpenTest()
        {
            var mock = new Moq.Mock<IMyDriver>();
            var client = new MyWork.MyConnection(new[] {mock.Object});
            mock.Setup(driver => driver.Connect());

            client.Open();
            
            mock.VerifyAll();
        }

        [Test]
        public void CloseTest()
        {
            var mock = new Mock<IMyDriver>();
            var client = new MyConnection(new[] {mock.Object});
            mock.Setup(driver => driver.Close());

            client.Close();

            mock.VerifyAll();
        }

        [Test]
        public void ConnectedTest()
        {
            var mock = new Mock<IMyDriver>();
            var client = new MyConnection(new[] {mock.Object});
            bool flag = false;
            client.Connected += (sender, args) => flag = true;

            client.Open();

            Assert.IsTrue(flag);
        }
    }
}