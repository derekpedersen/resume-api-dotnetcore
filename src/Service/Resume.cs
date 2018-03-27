using System;
using System.Collections.Generic;

using ResumeAPI.Model;

namespace ResumeAPI.Service
{
    public class ResumeService 
    {
        public Model.Resume GetResume()
        {
            return new Model.Resume
            {
                Title = "Derek Pedersen",
                Subtitle = "Full Stack Developer",
                Skillset = new string[]{
                    "C#",
                    "ASP.Net Web Api",
                    "Angular (1.0, 1.5, 2.0+)",
                    "Typescript",
                    "PowerShell",
                    "Azure Key Vault",
                    "Azure Storage",
                    "Azure Functions",
                    "git",
                    "TFVC",
                    "SVN",
                    "javascript",
                    "jQuery",
                    "SCSS",
                    "FlexBox",
                    "Selenium",
                    "REST",
                    "SOAP",
                    "GoCD",
                    "VSTS",
                    "Jira",
                    "Bamboo"
                },
                Content = "Full stack developer experienced in maintaining, building, and designing critical business applications and infrastructure. I have worked in a variety of environments from startup to Fortune 50 and in a range of roles from Software Developer to Solutions Architect."
            };
        }
    }
}