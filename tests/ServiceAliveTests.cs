using Microsoft.VisualStudio.TestTools.UnitTesting;

using ResumeAPI.Service;

namespace tests
{
    [TestClass]
    public class ServiceAliveTests
    {
        [TestMethod]
        public void GetAlive()
        {
            // Arrange
            var svc = new AliveService();

            // Act
            var result = svc.GetAlive();

            // Assert
            Assert.AreEqual("Johnny 5 Alive!", result.Message);
        }
    }
}
