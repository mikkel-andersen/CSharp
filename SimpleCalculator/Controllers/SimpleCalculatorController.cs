using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculator.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        [HttpGet]
        public ActionResult SimpleCalculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleCalculator(IFormCollection formCollection)
        {
            int number1 = int.Parse(formCollection["Number1"]);
            int number2 = int.Parse(formCollection["Number2"]);
            string Operator = formCollection["Operator"];
            double result;

            switch (Operator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 + number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operator");
            }

            ViewBag.Number1 = number1;
            ViewBag.Number2 = number2;
            ViewBag.Operator = Operator;
            ViewBag.Result = result;
            
            return View();
        }

    }
}
