using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using ResumeAPI.Repository;

namespace tests.Repository
{
    [TestClass]
    public class EducationRepositoryTests
    {
        [TestMethod]
        public async Task GetEducations()
        {
            // Arrange
            var repo = new EducationRepository();

            // Act
            var result = await repo.GetEducations();

            // Assert
            Assert.AreEqual(2, result.Count);
        }
    }
}
