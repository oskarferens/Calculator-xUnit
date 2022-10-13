using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public static int Multiplication(int firstInput, int secondInput)
        {
            return firstInput * secondInput;
        }

        public static double Division(double firstInput, double secondInput)
        {

            //resultInDouble = Math.Round(resultInDouble, 4);
            double result = firstInput / secondInput;
            result = Math.Round(result, 3);

            if (secondInput == 0 )
                Console.WriteLine("Dont divide by 0");
            else
                Console.Write("result = ");

            return result;
        }

        public static int Substraction(int firstInput, int secondInput)
        {
            int result = firstInput - secondInput;
            return result;
        }
        
        public static double Substraction(List<double> numbers)
        {
            double sum = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                sum -= numbers[i];
            }

            return sum;
        }

        public static int Addition(int firstInput, int secondInput)
        {
            int result = firstInput + secondInput;
            return result;
        }
        
        public static double Addition(List<double> numbers)
        {
            double sum = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
