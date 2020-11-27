using Microsoft.VisualStudio.TestTools.UnitTesting;

using ResumeAPI.Service;

namespace tests.Service
{
    [TestClass]
    public class ServiceResumeTests
    {
        [TestMethod]
        public void GetResume()
        {
            // Arrange
            var svc = new ResumeService();

            // Act
            var result = svc.GetResume();

            // Assert
            Assert.AreEqual("Derek Pedersen", result);
        }
    }
}
