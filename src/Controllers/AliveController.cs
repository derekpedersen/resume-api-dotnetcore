using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Service;

namespace ResumeAPI.Controllers
{
    [Route("[controller]")]
    public class AliveController : Controller
    {
        private AliveService _service { get; set; }

        public AliveController()
        {
            this._service = new AliveService();
        }

        [HttpGet]
        public async Task<IActionResult> GetAlive()
        {
            try
            {
                var alive = await this._service.GetAlive();

                return Ok(alive);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}