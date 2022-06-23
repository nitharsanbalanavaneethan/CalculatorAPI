using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorAPI
{
    
    public static class Calculator
    {
        //Calculate the value based on actiontype
        public static double calculate(double val1, double val2, int action)
        {
            double result = 0;

            switch (action)
            {
                case 1:
                    result = val1 + val2;
                    break;

                case 2:
                    result = val1 - val2;
                    break;

                case 3:
                    result = val1 * val2;
                    break;

                case 4:
                    result = val1 / val2;
                    break;

                default:
                    break;
            }

            return result;

        }
    }
}