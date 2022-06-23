using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculatorWebUI.Models;
using CalculatorAPI;

namespace CalculatorWebUI.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public ActionResult Index(Calc calc, string calculate)
        {
            if (calculate == "Add")
            {
                //Calling API to get the result
                calc.result = Calculator.calculate(calc.value1, calc.value2, Helper.Add);
            }
            else if (calculate == "Substract")
            {
                //Calling API to get the result
                calc.result = Calculator.calculate(calc.value1, calc.value2, Helper.Substract);
            }
            else if (calculate == "Multiply")
            {
                //Calling API to get the result
                calc.result = Calculator.calculate(calc.value1, calc.value2, Helper.Multiply);
            }
            else if (calculate == "Divide")
            {
                //Calling API to get the result
                calc.result = Calculator.calculate(calc.value1, calc.value2, Helper.Divide);
            }
            else
            {
                calc.result = 0;
            }

            return View(calc);
        }
    }
}