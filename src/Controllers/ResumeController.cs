using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ResumeAPI.Model;
using ResumeAPI.Service;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private ResumeService _service { get; set; }

        public ResumeController()
        {
            this._service = new ResumeService();
        }

        /// <summary>
        /// Gets my resume
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetResume()
        {
            try
            {
                var resume = this._service.GetResume();

                return Ok(resume);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Oops an error occured!");
            }
        }
    }
}