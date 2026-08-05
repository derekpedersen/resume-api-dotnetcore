using System;
using System.IO;
using System.Threading.Tasks;

using api.Models;
using api.Repository;

namespace api.Service
{
    public class ResumeService 
    {
        private ResumeRepository _repository { get; set; }

        public ResumeService()
        {
            this._repository = new ResumeRepository();
        }

        public async Task<Resume> GetResume()
        {
            var resume = await this._repository.GetResume();
            return resume;
        }

        public string GetResumeFilePath() {
            var env = Environment.GetEnvironmentVariable("RESUME_PDF_FILE");
            return string.IsNullOrEmpty(env)
                ? "../../../../docs/resume/Derek_Pedersen_Resume.pdf"
                : env;
        }
    }
}