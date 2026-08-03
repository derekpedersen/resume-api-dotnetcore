using System;

namespace api.Models;

public class Education
{
    public string School { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; } = string.Empty;
}
