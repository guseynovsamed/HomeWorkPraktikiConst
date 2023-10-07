using HomeWorkPraktikiConts.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktikiConts.Controllers
{
    internal class CalculateController
    {
        private CalculatorService _calculatorService;


        public CalculateController()
        {
            _calculatorService = new CalculatorService();
        }

        public void Calculate()
        {
            Console.WriteLine("Add First Number");
           Num1: string num1 = Console.ReadLine();

            double number1;

            bool isTrueNum1 = double.TryParse(num1 , out number1);

            if(!isTrueNum1 )
            {
                Console.WriteLine("Please add correct number");
                goto Num1;
            }



            Console.WriteLine("Please select one operation : + , - , * , / ");

            string operation = Console.ReadLine();




            Console.WriteLine("Add second number");
            Num2: string num2 = Console.ReadLine();

            double number2;

            bool isTrueNum2= double.TryParse(num2 , out number2);

            if(!isTrueNum2 )
            {
                Console.WriteLine("Please add correct number");
                goto Num2;
            }

            if(operation == "/" && number2 == 0)
            {
                Console.WriteLine("Cant be divide by zero");

                goto Num1;
            }


            string result = _calculatorService.Calculate(number1,number1,operation);


            Console.WriteLine(result);
        }
    }
}
