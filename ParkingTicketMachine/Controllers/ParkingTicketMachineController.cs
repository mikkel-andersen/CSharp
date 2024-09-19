using Microsoft.AspNetCore.Mvc;
using ParkingTicketMachine.Models;

namespace ParkingTicketMachine.Controllers
{
    public class ParkingTicketMachineController : Controller
    {
        [HttpGet]
        public ActionResult ParkingTicketMachine()
        {
            var model = new Models.ParkingTicketMachine();
            return View(model);
        }

        [HttpPost]
        public ActionResult ParkingTicketMachine(FormCollection formCollection)
        {
           
            return View();
        }
    }
}