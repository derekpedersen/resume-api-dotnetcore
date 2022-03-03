using Xunit;
using System.Threading.Tasks;

using api.Repository;

namespace tests.Repository;
public class JobRepositoryTests
{
    [Fact]
    public async Task GetJobs()
    {
        // Arrange
        var repo = new JobRepository();

        // Act
        var result = await repo.GetJobs();

        // Assert
        Assert.Equal(4, result.Count);
    }
}

