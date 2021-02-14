using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using ResumeAPI.Controllers;
using ResumeAPI.Model;

namespace tests.Controller
{
    [TestClass]
    public class ResumeControllerTests
    {
        [TestMethod]
        public async Task GetResume()
        {
            // Arrange
            var ctrl = new ResumeController();

            // Act
            var result = await ctrl.GetResume();
            var ok = result as OkObjectResult;
            var model = ok.Value as Resume;

            // Assert
            Assert.AreEqual("Derek", model.FirstName);
        }

        [TestMethod]
        public async Task DownloadResume()
        {
            // Arrange
            var ctrl = new ResumeController();

            // Act
            var result = await ctrl.DownloadResume();
            var ok = result as FileResult;

            // Assert
            Assert.AreEqual("Derek_Pedersen_Resume.pdf", ok.FileDownloadName);
        }
    }
}
