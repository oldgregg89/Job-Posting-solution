using System.Collections.Generic;

namespace JobPosting.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact JobContact { get; set; }
    private static List<JobOpening> _instances = new List<JobOpening> {};
    public JobOpening (string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      JobContact = contact;
      _instances.Add(this);
    }
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
  }
}