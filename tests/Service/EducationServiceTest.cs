using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using ResumeAPI.Service;

namespace tests.Service
{
    [TestClass]
    public class ServiceEducationTests
    {
        [TestMethod]
        public async Task GetEducations()
        {
            // Arrange
            var svc = new EducationService();

            // Act
            var result = await svc.GetEducations();

            // Assert
            Assert.AreEqual(2, result.Count);
        }
    }
}
