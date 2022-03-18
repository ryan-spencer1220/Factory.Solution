using Microsoft.AspNetCore.Mvc;

namespace SillystringFactory.Controllers
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