using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RockbandsController : Controller
    {
        // GET: /rockbands
        public ActionResult Index()
        {
            string[] rockbands = new[]
            {
                "City Morgue",
                "Rev Theory",
                "Bring me the horizon",
                "Oasis",
                "Amy Winehouse",
                "Queen",
                "Nirvana",
                "The Who",
                "U2",
                "Pink Floyd"

            };
            ViewBag.Rockbands = rockbands;
            return View("Rockbands");
        }

    }
}
