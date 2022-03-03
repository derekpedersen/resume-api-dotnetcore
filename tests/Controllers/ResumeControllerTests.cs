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
        var result = await ctrl.GetResume();
        var ok = result as OkObjectResult;
        var model = ok.Value as Resume;

        // Assert
        Assert.Equal("Derek", model.FirstName);
    }

    [Fact]
    public async Task DownloadResume()
    {
        // Arrange
        var ctrl = new ResumeController();

        // Act
        var result = await ctrl.DownloadResume();
        var ok = result as FileResult;

        // Assert
        Assert.Equal("Derek_Pedersen_Resume.pdf", ok.FileDownloadName);
    }
}

