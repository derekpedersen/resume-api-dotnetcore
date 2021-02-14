using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using ResumeAPI.Repository;

namespace tests.Repository
{
    [TestClass]
    public class ResumeRepositoryTests
    {
        [TestMethod]
        public async Task GetResume()
        {
            // Arrange
            var repo = new ResumeRepository();

            // Act
            var result = await repo.GetResume();

            // Assert
            Assert.AreEqual("Derek", result.FirstName);
        }
    }
}
