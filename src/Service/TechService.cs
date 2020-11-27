using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;
using ResumeAPI.Repository;

namespace ResumeAPI.Service
{
    public class TechService 
    {
        private TechRepository _repository { get; set; }

        public TechService()
        {
            this._repository = new TechRepository();
        }

        public async Task<List<Tech>> GetTechs()
        {
            var techs = await this._repository.GetTechs();

            return techs;
        }
    }
}