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
            Content = "**Software Engineer** by day, skateboarder by weekend.<br />" +
            "<br />" + 
            "I'm a full stack software engineer and I've worked in a variety of fields(e - commerce, healthcare, consulting) across a range of business environments(start - up to fortune 50).<br />" + 
            "<br />" + 
            "Used to spend most my days writing[C#](https://docs.microsoft.com/en-us/dotnet/csharp/) but now I'm onto that [Golang](https://golang.org/).<br />" +
            "<br />" + 
            "Started with[ASP.NET web forms](https://www.asp.net/web-forms) and [jQuery](https://jquery.com/) now building SPAs using [angular](https://angular.io/).<br />" +
            "<br />" +
            "Preferred Environment: Definitely[Debian](https://www.debian.org/) based linux.<br />"
            };
    }
}