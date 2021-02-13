using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using ResumeAPI.Service;
using ResumeAPI.Model;

namespace tests.Service
{
    [TestClass]
    public class ServiceJobTests
    {
        [TestMethod]
        public async Task GetJobs()
        {
            // Arrange
            var svc = new JobService();

            // Act
            var result = await svc.GetJobs();

            // Assert
            Assert.AreEqual(4, result.Count);
        }
    }
}
