using MyDriver;
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
    }
}