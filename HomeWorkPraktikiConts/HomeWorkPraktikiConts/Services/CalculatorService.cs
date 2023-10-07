using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktikiConts.Services
{
    internal class CalculatorService
    {
        public string Calculate(double num1 , double num2 , string operation)
        {
            string result;

            switch (operation)
            {
                case "+":

                    result = (num1 + num2).ToString();
                    return result;
                    
                case "-":
                    result = (num1 - num2).ToString();
                    return result;
                    
                case "*":
                    result = (num1 * num2).ToString();
                    return result;
                    
                case "/":
                    result = (num1 / num2).ToString();
                    return result;
                default:
                    result = "Operator invalid";
                    return result;

                    


               


            }

            
        

        }
    }
}
