using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using ResumeAPI.Service;
using ResumeAPI.Model;

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
