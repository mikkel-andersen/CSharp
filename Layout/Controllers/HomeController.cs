using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Sale()
        {
            return View();
        }
        
        public ActionResult MoreSale()
        {
            return View("MoreSale");
        }
        
        public ActionResult Buy()
        {
            return View("Buy");
        }
        
        public ActionResult BuyAndSell()
        {
            return View("BuyAndSell");
        }
        

    }
}
