using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;
using System.Collections.Generic;

namespace JobPosting.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/job-openings")]
    public ActionResult Index()
    {
      List<JobOpening> allJobs = JobOpening.GetAll();
      return View(allJobs);
    }

    [HttpGet("/job-openings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [HttpPost("/job-openings")]
    public ActionResult Create(string jobName, string description, string contactName, string email, string phoneNumber)
    {
      Contact newContact = new Contact (contactName, email, phoneNumber);
      JobOpening newJobOpening = new JobOpening(jobName, description, newContact);
      return RedirectToAction("Index");
    }
  }
}