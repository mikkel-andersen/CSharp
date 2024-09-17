using Microsoft.AspNetCore.Mvc;
using System;

namespace PartialView.Components
{
    public class VisEnPerson : ViewComponent
    {
        public IViewComponentResult Invoke(Person p)
        {
            // Ændrer person objektet
            if (p.Age < 18)
            {
                p.Navn = "Anonym";
                p.Efternavn = "Anonym";
            }
            else
            {
                // Eksempel på ændring: Byt om på fornavn og efternavn
                var temp = p.Navn;
                p.Navn = p.Efternavn;
                p.Efternavn = temp;
            }

            return View(p);
        }
    }
}