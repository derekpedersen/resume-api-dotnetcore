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
        var ok = result as OkObjectResult;
        var model = ok.Value as Alive;

        // Assert
        Assert.Equal("Johnny 5 Alive!", model.Message);
    }
}

