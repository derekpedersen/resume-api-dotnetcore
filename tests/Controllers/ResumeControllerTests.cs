using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Controllers;
using ResumeAPI.Model;

namespace tests.Controller
{
    [TestClass]
    public class ResumeControllerTests
    {
        [TestMethod]
        public async void GetResume()
        {
            // Arrange
            var ctrl = new ResumeController();

            // Act
            var result = await ctrl.GetResume();
            var ok = result as OkObjectResult;
            var model = ok.Value as Alive;

            // Assert
            Assert.AreEqual("Johnny 5 Alive!", result);
        }
    }
}
