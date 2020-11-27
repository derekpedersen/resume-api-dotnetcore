using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;
using ResumeAPI.Repository;

namespace ResumeAPI.Service
{
    public class EducationService 
    {
        private EducationRepository _repository { get; set; }

        public EducationService()
        {
            this._repository = new EducationRepository();
        }

        public async Task<List<Education>> GetEducations()
        {
            var educations = await this._repository.GetEducations();

            return educations;
        }
    }
}