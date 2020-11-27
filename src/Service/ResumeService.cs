using System;
using System.IO;
using System.Threading.Tasks;

using ResumeAPI.Model;
using ResumeAPI.Repository;

namespace ResumeAPI.Service
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
    }
}