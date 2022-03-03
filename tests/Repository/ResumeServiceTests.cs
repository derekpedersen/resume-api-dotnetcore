using Xunit;
using System.Threading.Tasks;
using api.Repository;

namespace tests.Repository;
public class ResumeRepositoryTests
{
    [Fact]
    public async Task GetResume()
    {
        // Arrange
        var repo = new ResumeRepository();

        // Act
        var result = await repo.GetResume();

        // Assert
        Assert.Equal("Derek", result.FirstName);
    }
}

