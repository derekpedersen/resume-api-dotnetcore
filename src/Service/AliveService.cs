using System;
using System.Threading.Tasks;

using ResumeAPI.Model;

namespace ResumeAPI.Service
{
    public class AliveService 
    {
        public async Task<Alive> GetAlive()
        {
            return new Model.Alive
            {
                Message = "Johnny 5 Alive!"
            };
        }
    }
}