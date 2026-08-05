using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using api.Controllers;
using api.Models;

namespace tests.Controller;
public class AliveControllerTests
{
    [Fact]
    public async Task GetAlive()
    {
        // Arrange
        var ctrl = new AliveController();

        // Act
        var result = await ctrl.GetAlive();
        var ok = Assert.IsType<OkObjectResult>(result);
        var model = Assert.IsType<Alive>(ok.Value);

        // Assert
        Assert.Equal("Johnny 5 Alive!", model.Message);
    }
}

