using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("string","string", 0, "string");
      return View(starterOrder);
    }

  }
}