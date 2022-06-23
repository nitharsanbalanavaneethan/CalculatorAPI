using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class CalcController : ApiController
    {
        double result;

        [HttpGet]
        public string Get()
        {
            return "Calculator";
        }

        //https://localhost:44334/api/calc/Add/?value1=1.2&value2=3.1
        [HttpGet]
        public double Add(string value1, string value2)
        {
            double val1 = Convert.ToDouble(value1);
            double val2 = Convert.ToDouble(value2);

            result = Calculator.calculate(val1, val2, Helper.Add);

            return result;
        }

        [HttpGet]
        public double Substract(string value1, string value2)
        {
            double val1 = Convert.ToDouble(value1);
            double val2 = Convert.ToDouble(value2);

            result = Calculator.calculate(val1, val2, Helper.Substract);

            return result;
        }

        [HttpGet]
        public double Multiply(string value1, string value2)
        {
            double val1 = Convert.ToDouble(value1);
            double val2 = Convert.ToDouble(value2);

            result = Calculator.calculate(val1, val2, Helper.Multiply);

            return result;
        }

        
        [HttpGet]
        public double Divide(string value1, string value2)
        {
            double val1 = Convert.ToDouble(value1);
            double val2 = Convert.ToDouble(value2);

            result = Calculator.calculate(val1, val2, Helper.Divide);

            return result;
        }

        //public double calculate(double val1, double val2, int action)
        //{
        //    //double result = 0;

        //    switch (action)
        //    {
        //        case 1:
        //            result = val1 + val2;
        //            break;

        //        case 2:
        //            result = val1 - val2;
        //            break;

        //        case 3:
        //            result = val1 * val2;
        //            break;

        //        case 4:
        //            result = val1 / val2;
        //            break;

        //        default:
        //            break;
        //    }

        //    return result;

        //}


    }
}
