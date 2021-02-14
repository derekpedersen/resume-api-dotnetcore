using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Service;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private ResumeService _service { get; set; }

        public ResumeController()
        {
            this._service = new ResumeService();
        }

        [HttpGet]
        public async Task<IActionResult> GetResume()
        {
            try
            {
                var resume = await this._service.GetResume();

                return Ok(resume);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("/api/resume/download")]
        public async Task<IActionResult> DownloadResume() 
        {
            try
            {
                var dataBytes = System.IO.File.ReadAllBytes(this._service.GetResumeFilePath()); 
                var dataStream = new MemoryStream(dataBytes); 

                if(dataStream == null) return NotFound();

                return File(dataStream, "application/octet-stream", "Derek_Pedersen_Resume.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}