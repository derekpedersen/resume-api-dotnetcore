using Xunit;
using System.Threading.Tasks;

using api.Service;

namespace tests.Service;

public class ServiceEducationTests
{
    [Fact]
    public async Task GetEducations()
    {
        // Arrange
        var svc = new EducationService();

        // Act
        var result = await svc.GetEducations();

        // Assert
        Assert.Equal(2, result.Count);
    }
}

