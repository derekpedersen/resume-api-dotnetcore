using System;
using System.Collections.Generic;

using ResumeAPI.Model;

namespace ResumeAPI.Service
{
    public class AliveService 
    {
        public Model.Alive GetAlive()
        {
            return new Model.Alive
            {
                Message = "Johnny 5 Alive!"
            };
        }
    }
}