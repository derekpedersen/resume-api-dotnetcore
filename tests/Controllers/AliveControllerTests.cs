using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Controllers;
using ResumeAPI.Model;

namespace tests.Controller
{
    [TestClass]
    public class AliveControllerTests
    {
        [TestMethod]
        public async void GetAlive()
        {
            // Arrange
            var ctrl = new AliveController();

            // Act
            var result = await ctrl.GetAlive();
            var ok = result as OkObjectResult;
            var model = ok.Value as Alive;

            // Assert
            Assert.AreEqual("Johnny 5 Alive!", result);
        }
    }
}
