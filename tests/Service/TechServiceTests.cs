using Xunit;
using System.Threading.Tasks;

using api.Service;

namespace tests.Service;
public class TechServiceTests
{
    [Fact]
    public async Task GetTechs()
    {
        // Arrange
        var svc = new TechService();

        // Act
        var result = await svc.GetTechs();

        // Assert
        Assert.Equal(1, result.Count);
    }
}

