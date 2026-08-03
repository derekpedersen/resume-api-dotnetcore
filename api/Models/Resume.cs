using System.Collections.Generic;

namespace api.Models;
public class Resume
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string URL { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string[] Skillset { get; set; } = Array.Empty<string>();
    public string[] Content { get; set; } = Array.Empty<string>();
    public List<Job> Jobs { get; set; } = new();
    public List<Education> Educations { get; set; } = new();
}
