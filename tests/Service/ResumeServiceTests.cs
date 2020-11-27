using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Service;
using ResumeAPI.Model;

namespace tests.Service
{
    [TestClass]
    public class ServiceResumeTests
    {
        [TestMethod]
        public async void GetResume()
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
