using System;

namespace api.Models;
public class Job
{
    public string CompanyName { get; set; } = string.Empty;
    public string URL { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; } = string.Empty;
}
