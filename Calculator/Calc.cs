using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        public static void Multiplication(int firstInput, int secondInput)
        {
            Console.WriteLine("result = " + firstInput * secondInput);
        }

        public static void Division(int firstInput, int secondInput)
        {
            double firstInputDouble = Convert.ToDouble(firstInput);
            double secondInputDouble = Convert.ToDouble(secondInput);
            double resultInDouble = firstInputDouble / secondInputDouble;
            resultInDouble = Math.Round(resultInDouble, 4);

            if (secondInputDouble == 0)
                Console.WriteLine("Dont divide by 0");
            else
                Console.WriteLine("result = " + resultInDouble);
        }

        public static void Subtraction(int firstInput, int secondInput)
        {
            Console.WriteLine("result = " + (firstInput - secondInput));
        }

        public static void Addition(int firstInput, int secondInput)
        {
            Console.WriteLine("result = " + (firstInput + secondInput));
        }
    }
}
