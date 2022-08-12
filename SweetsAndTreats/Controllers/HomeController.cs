using Microsoft.AspNetCore.Mvc;

namespace SweetsAndTreats.Controllers
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