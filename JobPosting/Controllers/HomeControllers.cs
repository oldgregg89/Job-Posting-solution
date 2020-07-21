using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;

namespace JobPosting.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}