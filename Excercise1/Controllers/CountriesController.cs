using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;
using Excercise1.Infrastructure;

namespace Excercise1.Controllers
{
    public class CountriesController : Controller
    {
        private const string SessionKeyCountries = "countryList";

        private List<SelectListItem> GetCountries()
        {
            var sessionCountries = HttpContext.Session.GetString(SessionKeyCountries);
            if (sessionCountries != null)
            {
                return JsonConvert.DeserializeObject<List<SelectListItem>>(sessionCountries);
            }
            else
            {
                var defaultCountries = new List<SelectListItem>
                {
                    new SelectListItem { Text = "China", Value = "CN" },
                    new SelectListItem { Text = "Denmark", Value = "DK" },
                    new SelectListItem { Text = "United Kingdom", Value = "UK" },
                    new SelectListItem { Text = "Germany", Value = "GER" }
                };
                HttpContext.Session.SetString(SessionKeyCountries, JsonConvert.SerializeObject(defaultCountries));
                return defaultCountries;
            }
        }

        [HttpGet]
        public ActionResult Countries()
        {
            ViewBag.Countries = GetCountries();
            return View();
        }

        [HttpGet]
        public ActionResult ShowCountries(string countries)
        {
            ViewBag.Countries = GetCountries();
            ViewBag.CountryCode = countries;
            return View("Countries");
        }

        [HttpPost]
        public ActionResult AddCountry(IFormCollection formData)
        {
            var country = formData["Country"];
            var code = formData["Code"];
            var countries = GetCountries();
            countries.Add(new SelectListItem { Text = country, Value = code });
            Utilities.SortSelectList(countries, code); // Sort and select the new country
            HttpContext.Session.SetString(SessionKeyCountries, JsonConvert.SerializeObject(countries));
            ViewBag.Countries = countries;
            return View("Countries");
        }
    }
}