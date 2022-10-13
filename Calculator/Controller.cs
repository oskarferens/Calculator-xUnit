using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Controller
    {
        public static void StartApplication()
        {
            bool working = true;
            

            while (working)
            {
                int firstInput;
                int secondInput;
                char option;
                List<double> numberList = new List<double> { 8.5, 5.2 };

                Console.WriteLine("Choose an action *,+,-,/ or press . to exit");
                option = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                firstInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                secondInput = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case '-':
                        {
                            Console.WriteLine("result is : " + Calc.Substraction(firstInput,secondInput));
                            break;
                        }
                    case '+':
                        {
                            Console.WriteLine("result is : " + Calc.Addition(firstInput, secondInput));
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("result is : " + Calc.Multiplication(firstInput, secondInput));
                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine(Calc.Division(firstInput, secondInput));
                            break;
                        }
                    case '.':
                        {
                            Console.Clear();
                            Console.WriteLine("Bye!");
                            working = false;
                            break;
                        }

                }
            }
        }
    }
}
