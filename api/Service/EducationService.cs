using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using api.Models;
using api.Repository;

namespace api.Service
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