using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Model;
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

        /// <summary>
        /// Gets Alive message
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAlive()
        {
            try
            {
                var alive = this._service.GetAlive();

                return Ok(alive);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Oops an error occured!");
            }
        }
    }
}