using Xunit;
using System.Threading.Tasks;

using api.Service;

namespace tests.Service;

public class ServiceResumeTests
{
    [Fact]
    public async Task GetResume()
    {
        // Arrange
        var svc = new ResumeService();

        // Act
        var result = await svc.GetResume();

        // Assert
        Assert.Equal("Derek", result.FirstName);
    }
}

