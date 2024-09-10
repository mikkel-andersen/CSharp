using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            var person = new Person
            {
                Name = "Mikkel",
                Age = 24,
                Birthday = new DateTime(1999, 10, 28)
            };
            return View(person);
        }

    }
}
