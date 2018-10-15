using System.Web.Mvc;
using BabysitterWageCalculator.Web.Models;
namespace BabysitterWageCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Models.BabysitterWageCalculator babysitterWageCalculator)
        {
            return View("Index", babysitterWageCalculator);
        }
    }
}