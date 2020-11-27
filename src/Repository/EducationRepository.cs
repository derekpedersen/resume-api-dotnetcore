using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ResumeAPI.Model;

namespace ResumeAPI.Repository
{
    public class EducationRepository
    {
        public async Task<List<Education>> GetEducations() => new List<Education>()
        {
            new Education 
            {
                School = "Western Washington University",
                Degree = "B.A. Philosophy & Economics (double major)",
                StartDate = DateTime.Parse("2005-09-01"),
                EndDate = DateTime.Parse("2010-01-01"),
                Description = "My education in philosophy consisted of a rigorous study of logical thinking, critical analysis, and proper argumentation mainly expressed through written essays. My education in economics consisted of a study of rational behavior and potential outcomes in such  areas as macroeconomics, international trade, public finance, industrial organization, and the labor market through the use of critical analysis tools."
            },
            new Education 
            {
                School = "Seattle Central Community College",
                Degree = "Database Design & Administration Certificate",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = DateTime.Parse("2011-12-31"),
                Description = "My study focused on all aspects of relational databases from their design and proper modeling to documenting database structures and rules, maintaining and retrieving data, performing security administration functions to ensure the protection of data integrity, and the use of databases in creating programs and dynamic websites."
            }
        };
    }
}