using System;
using System.Collections.Generic;

namespace api.Models;
    public class Tech 
    {
        public string Technology { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Job> Jobs { get; set; } = new();
        public string SkillLevel { get; set; } = string.Empty;
    }
