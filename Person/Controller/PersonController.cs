using Microsoft.AspNetCore.Mvc;
using Person.Models;

namespace Person.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private static List<Models.Person> persons = new List<Models.Person>
        {
            new Models.Person { Id = 1, Name = "Mikkel Andersen", Age = 24 },
            new Models.Person { Id = 2, Name = "Jens Ulrik", Age = 27 }
        };

        [HttpGet("getPersoner")]
        public ActionResult<IEnumerable<Models.Person>> GetPersoner()
        {
            return Ok(persons);
        }

        [HttpGet("getPersonById/")]
        public ActionResult<Models.Person> GetPersonById(int id)
        {
            var person = persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost("addPerson")]
        public ActionResult<Models.Person> AddPerson(Models.Person p)
        {
            persons.Add(p);
            Console.WriteLine($"Person added: {p.Name}, Age: {p.Age}");
            return Ok(p);
        }
    }
}