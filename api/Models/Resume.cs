using System.Collections.Generic;

namespace api.Models;
public class Resume
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;
    public string URL;
    public string Title;
    public string Subtitle;
    public string Description;
    public string[] Skillset;
    public string[] Content;
    public List<Job> Jobs;
    public List<Education> Educations;
}
