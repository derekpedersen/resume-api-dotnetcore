using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using ResumeAPI.Repository;

namespace tests.Repository
{
    [TestClass]
    public class JobRepositoryTests
    {
        [TestMethod]
        public async Task GetJobs()
        {
            // Arrange
            var repo = new JobRepository();

            // Act
            var result = await repo.GetJobs();

            // Assert
            Assert.AreEqual(4, result.Count);
        }
    }
}
