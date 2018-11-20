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
                Subtitle = "Full Stack Software Engineer",
                Skillset = new string[]{
                    "C#",
                    "ASP.NET Web Api",
                    "Angular",
                    "Typescript",
                    "Azure",
                    "jQuery",
                    "SCSS",
                    "Selenium",
                    "CI/CD Pipelines",
                    "Golang",
                    "SQL",
                    "Kubernetes",
                    "Google Cloud"
                },
                Content = "I’m a full stack software engineer and I’ve worked in a variety of fields (e-commerce, healthcare, consulting) across a range of business environments (start-up to fortune 50)."
            };
        }
    }
}