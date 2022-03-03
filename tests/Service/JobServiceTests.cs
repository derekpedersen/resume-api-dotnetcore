using Xunit;
using System.Threading.Tasks;

using api.Service;

namespace tests.Service;
public class ServiceJobTests
{
    [Fact]
    public async Task GetJobs()
    {
        // Arrange
        var svc = new JobService();

        // Act
        var result = await svc.GetJobs();

        // Assert
        Assert.Equal(4, result.Count);
    }
}

