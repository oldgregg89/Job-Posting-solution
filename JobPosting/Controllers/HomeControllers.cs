using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;

namespace JobPosting.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}