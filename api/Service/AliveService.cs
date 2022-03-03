using System;
using System.Threading.Tasks;

using api.Models;

namespace api.Service;
public class AliveService
{
    public async Task<Alive> GetAlive()
    {
        return new Models.Alive
        {
            Message = "Johnny 5 Alive!"
        };
    }
}
