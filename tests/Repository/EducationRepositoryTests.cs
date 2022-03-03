using Xunit;
using System.Threading.Tasks;

using api.Repository;

namespace tests.Repository;
public class EducationRepositoryTests
{
    [Fact]
    public async Task GetEducations()
    {
        // Arrange
        var repo = new EducationRepository();

        // Act
        var result = await repo.GetEducations();

        // Assert
        Assert.Equal(2, result.Count);
    }
}

