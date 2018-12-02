using System;
using System.Collections.Generic;

using ResumeAPI.Model;

namespace ResumeAPI.Service
{
    public class ResumeService 
    {
        public Model.Resume GetResume() => new Model.Resume
        {
            Title = "Derek Pedersen",
            Subtitle = "Full Stack Software Engineer",
            Skillset = new string[]{
                    // back end
                    "Golang",
                    "C#",
                    "VB",
                    "",
                    "",
                    // front end
                    "Angular (1.0, 1.5, 2.0+)",
                    "jQuery",
                    "ASP.NET Web Forms",
                    "",
                    "",
                    // data storage
                    "Sql Server",
                    "MySQL",
                    "PostgreSQL",
                    "",
                    "",
                    // data science 
                    "Jupyter Notebook",
                    "",
                    "",
                    "",
                    "",
                    // infrastructure
                    "Kubernetes",
                    "Google Cloud",
                    "Microsoft Azure",
                    "Debian",
                    "Windows"
                },
            Content = new string[] {
                "Software Engineer by day, skateboarder by weekend.",
                "I'm a full stack software engineer and I've worked in a variety of fields(e - commerce, healthcare, consulting) across a range of business environments(start - up to fortune 50).",
                "Used to spend most my days writing C# but now I'm onto that Golang.",
                "Started with ASP.NET web forms and jQuery now building SPAs using angular.",
                "Preferred Environment: Definitely Debian based linux."
                }
            };
    }
}