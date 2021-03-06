using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using ResumeAPI.Service;

namespace tests.Service
{
    [TestClass]
    public class ServiceResumeTests
    {
        [TestMethod]
        public async Task GetResume()
        {
            // Arrange
            var svc = new ResumeService();

            // Act
            var result = await svc.GetResume();

            // Assert
            Assert.AreEqual("Derek", result.FirstName);
        }
    }
}
