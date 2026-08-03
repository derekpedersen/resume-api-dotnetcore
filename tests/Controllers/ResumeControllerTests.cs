using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using api.Controllers;
using api.Models;

namespace tests.Controller;
public class ResumeControllerTests
{
    [Fact]
    public async Task GetResume()
    {
        // Arrange
        var ctrl = new ResumeController();

        // Act
        var result = await ctrl.Get();
        var ok = Assert.IsType<OkObjectResult>(result);
        var model = Assert.IsType<Resume>(ok.Value);

        // Assert
        Assert.Equal("Derek", model.FirstName);
    }

    [Fact]
    public async Task DownloadResume()
    {
        // Arrange
        var ctrl = new ResumeController();

        // Act
        var result = await ctrl.Download();
        var fileResult = Assert.IsAssignableFrom<FileResult>(result);

        // Assert
        Assert.Equal("Derek_Pedersen_Resume.pdf", fileResult.FileDownloadName);
    }
}

