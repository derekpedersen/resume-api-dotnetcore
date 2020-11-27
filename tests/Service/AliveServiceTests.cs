using Microsoft.VisualStudio.TestTools.UnitTesting;

using ResumeAPI.Service;

namespace tests.Service
{
    [TestClass]
    public class ServiceAliveTests
    {
        [TestMethod]
        public async void GetAlive()
        {
            // Arrange
            var svc = new AliveService();

            // Act
            var result = await svc.GetAlive();

            // Assert
            Assert.AreEqual("Johnny 5 Alive!", result.Message);
        }
    }
}
