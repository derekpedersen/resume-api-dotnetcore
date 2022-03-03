using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using api.Models;

namespace api.Repository
{
    public class TechRepository 
    {
        public async Task<List<Tech>> GetTechs() => new List<Tech>()
        {
            new Tech 
            {
                Description = ""
            }
        };
    }
}