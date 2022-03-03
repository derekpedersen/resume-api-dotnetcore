using Xunit;
using System.Threading.Tasks;
using api.Repository;

namespace tests.Repository;
public class TechRepositoryTests
{
    [Fact]
    public async Task GetTechs()
    {
        // Arrange
        var repo = new TechRepository();

        // Act
        var result = await repo.GetTechs();

        // Assert
        Assert.Equal(1, result.Count);
    }
}

