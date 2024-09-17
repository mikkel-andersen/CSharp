using Microsoft.AspNetCore.Mvc;
namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person("Mikkel", "Andersen", 12),
                new Person("Jens", "Hansen", 15),
                new Person("Tully", "Smith", 9)
            };
        }
        
        // GET: HomeController
        public ActionResult VisAlle()
        {
           var persons = GetPersons();
            return View(persons);
        }

        public ActionResult VisEn()
        {
            var person = GetPersons().ElementAt(1);
            return View(person);
        }

    }
}
