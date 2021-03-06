using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using ResumeAPI.Service;

namespace tests.Service
{
    [TestClass]
    public class TechServiceTests
    {
        [TestMethod]
        public async Task GetTechs()
        {
            // Arrange
            var svc = new TechService();

            // Act
            var result = await svc.GetTechs();

            // Assert
            Assert.AreEqual(1, result.Count);
        }
    }
}
