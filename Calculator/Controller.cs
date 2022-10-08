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
        Calc calc = new Calc();
        public static void StartApplication()
        {
            bool working = true;
            int firstInput;
            int secondInput;
            char option;
            do
            {
                Console.WriteLine("Enter 1st input");
                firstInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                secondInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an action *,+,-,/ or press . to exit");
                option = Convert.ToChar(Console.ReadLine());

                switch (option)
                {
                    case '+':
                        {
                            Calc.Addition(firstInput, secondInput);
                            break;
                        }
                    case '-':
                        {
                            Calc.Subtraction(firstInput, secondInput);
                            break;
                        }
                    case '*':
                        {
                            Calc.Multiplication(firstInput, secondInput);
                            break;
                        }
                    case '/':
                        {
                            Calc.Division(firstInput, secondInput);
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
            } while (working);
        }
    }

}
