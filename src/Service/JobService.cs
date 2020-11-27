using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;
using ResumeAPI.Repository;

namespace ResumeAPI.Service
{
    public class JobService 
    {
        private JobRepository _repository { get; set; }

        public JobService()
        {
            this._repository = new JobRepository();
        }

        public async Task<List<Job>> GetJobs()
        {
            var jobs = await this._repository.GetJobs();

            return jobs;
        }
    }
}