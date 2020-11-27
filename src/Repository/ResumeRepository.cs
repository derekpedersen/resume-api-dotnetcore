using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;

namespace ResumeAPI.Repository
{
    public class ResumeRepository 
    {
        public async Task<Resume> GetResume() => new Resume
        {
            FirstName = "Derek",
            LastName = "Pedersen",
            EmailAddress = "resume [at] pedersen [dot] io",
            PhoneNumber = "",
            URL = "https://pedersen.io",
            Title = "Senior Software Engineer",
            Subtitle = "Software developer by day, ski bum by weekend",
            Description = ""
        };
    }
}