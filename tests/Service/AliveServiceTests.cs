using Xunit;
using System.Threading.Tasks;

using api.Service;

namespace tests.Service;

public class ServiceAliveTests
{
    [Fact]
    public async Task GetAlive()
    {
        // Arrange
        var svc = new AliveService();

        // Act
        var result = await svc.GetAlive();

        // Assert
        Assert.Equal("Johnny 5 Alive!", result.Message);
    }
}

