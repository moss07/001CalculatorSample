using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001CalculatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenApp();
            Console.Write("1.Number is :  ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("2.Number is :  ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("*** Please Choose Operation:  \"+\", \"-\", \"*\", \"/\"  : ");
            string o = Console.ReadLine();
            if (o == "+")
            {
                double result = Sum(n1, n2);
                Console.WriteLine("Result is: " + n1 + " + " + n2 + " = " + result);
            }
            else if (o == "-")
            {
                double result = Substract(n1, n2);
                Console.WriteLine("Result is: " + n1 + " - " + n2 + " = " + result);
            }
            else if (o == "*")
            {
                double result = Multiply(n1, n2);
                Console.WriteLine("Result is: " + n1 + " * " + n2 + " = " + result);
            }
            else if (o == "/")
            {
                double result = Divide(n1, n2);
                Console.WriteLine("Result is: " + n1 + " / " + n2 + " = " + result);
            }
            else
            {
                Console.WriteLine("Chosen Wrong Operation. Please try again! ");
            }

            Console.ReadLine();
        }

        static void OpenApp()
        {
            Console.WriteLine("*** Welcome to the Most Famous Calculator in Space ***");
        }

        static double Sum(double n1, double n2)
        {
            double result = n1 + n2;
            return result;
        }

        static double Substract(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }

        static double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            return result;
        }

        static double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
    }
}
