using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using ResumeAPI.Repository;

namespace tests.Repository
{
    [TestClass]
    public class TechRepositoryTests
    {
        [TestMethod]
        public async Task GetTechs()
        {
            // Arrange
            var repo = new TechRepository();

            // Act
            var result = await repo.GetTechs();

            // Assert
            Assert.AreEqual(1, result.Count);
        }
    }
}
