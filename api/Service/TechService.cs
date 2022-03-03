using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using api.Models;
using api.Repository;

namespace api.Service
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