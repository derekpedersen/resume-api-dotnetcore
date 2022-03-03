using System;
using System.Collections.Generic;

namespace api.Models;
    public class Tech 
    {
        public string Technology;

        public DateTime StartDate;
        public DateTime EndDate;
        public string Description;      
        public List<Job> Jobs;
        public string SkillLevel;
    }
