using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;

namespace ResumeAPI.Repository
{
    public class JobRepository
    {
        public async Task<List<Job>> GetJobs() => new List<Job>()
        {
            new Job 
            {
                CompanyName = "ATGStores",
                URL = "https://atgstores.com",
                Position = "Software Team Lead",
                StartDate = DateTime.Parse("2012-02-01"),
                EndDate = DateTime.Parse("2016-05-01"),
                Description = "Responsible for overseeing the design, development, and implementation of business applications with a primary focus on web based solutions utilizing technologies across the full .NET stack."
            },
            new Job 
            {
                CompanyName = "iTrellis",
                Position = "Software Consultant",
                Description = "Helped clients maintain their application portfolios through development and maintenance of new and existing applications. While also evaluating their current development practices in an effort to help them achieve a quicker rate of delivery of new features by minimizing the introduction of bugs.",
                URL = "https://itrellis.com/",
                StartDate = DateTime.Parse("2016-05-01"),
                EndDate = DateTime.Parse("2017-12-31")
            },
            new Job 
            {
                CompanyName = "MultiScale Health Networks",
                Position = "Software Engineer",
                Description = "Helped deliver cloud based healthcare solutions that enable care providers to spend more meaningful and efficient time with patients. I primarily worked on delivering healthcare information in real time to resource decision makers such as the department charge nurse or the house supervisor",
                URL = "https://multiscale.io/",
                StartDate = DateTime.Parse("2018-01-01"),
                EndDate = DateTime.Parse("2019-05-01")
            },
            new Job 
            {
                CompanyName = "Navigating Cancer",
                Position = "Senior Software Engineer",
                URL = "https://www.navigatingcancer.com/",
                Description = "Part of a team leading an initiative to move the organisation from a ECS based approach to a EKS based one. Which entailed breaking apart monolithic application deployments while also moving to a CI/CD development workflow.",
                StartDate = DateTime.Parse("2019-05-01"),
                EndDate = null
            }
        };
    }
}