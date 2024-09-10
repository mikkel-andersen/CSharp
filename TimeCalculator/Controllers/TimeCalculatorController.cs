using Microsoft.AspNetCore.Mvc;

namespace TimeCalculator.Controllers
{
    public class TimeCalculatorController : Controller
    {
        // GET: TimeCalculatorController
        [HttpGet]
        public ActionResult TimeCalculator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = int.Parse(formCollection["hours"]);
            int minutes = int.Parse(formCollection["minutes"]);
            int seconds = int.Parse(formCollection["seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.hours = hours;
            ViewBag.minutes = minutes;
            ViewBag.seconds = seconds;
            ViewBag.total = total;
            return View("TimeCalculatorResult");
        }

    }
}
