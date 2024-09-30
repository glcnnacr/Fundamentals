using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Methods
{
    public class Maths
    {
        public static void Add(int number1, int number2)
        {
            Console.WriteLine($"Sum: {number1 + number2}");
        }

        public static long Add(long number1, int number2)
        {
            return number1 + number2;
        }

        public static int Add(byte number1, byte number2)
        {
            return number1 + number2;
        }

        public static int Add(short number1, short number2)
        {
            return number1 + number2;
        }

        public static long Add(long number1, long number2)
        {
            return number1 + number2;
        }

        public static float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// Adds two decimal numbers and returns the result.
        /// </summary>
        /// <param name="number1">Must be of type decimal</param>
        /// <param name="number2">Must be of type decimal</param>
        /// <returns>Returns a decimal value</returns>

        public static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public static double CalculatePower(double baseValue, double exponent)
        {
            double result = 1;

            Math.Pow(2, 2);
            if (exponent < 1)
            {
                //baseValue = 1 / baseValue;
                //exponent = -exponent;
            }

            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }

            return result;
        }

        public static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Factorial using recursive method

        public static long FactorialRecursive(int number)
        {

            //if (number < 0)
            //{
            //    Console.WriteLine("Negative numbers are not allowed");
            //    return 1;
            //}
            if (number >= 2)
            {
                return number * FactorialRecursive(number - 1);
            }
            else
            {
                return 1;
            }
        }

        public static double PerformOperation(char operation)
        {
            double number1 = (double)Screen.ReadNumber("Enter a double number:");
            double number2 = (double)Screen.ReadNumber("Enter another double number:");
            switch (operation)
            {
                case '+':
                    return number1 + number2;
                case '-':
                    return number1 - number2;
                case '/':
                    try
                    {
                        return number1 / number2;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Division by zero error");
                        return 0;
                    }
                case '*':
                    return number1 * number2;
                default:
                    Console.WriteLine("An unexpected situation occurred.");
                    return 0;
            }
        }
        
        public static double PerformOperation(double number1, double number2, char operation)
        {

            double result = 0;
            switch (operation)
            {
                case '+':
                    return number1 + number2;
                case '-':
                    return number1 - number2;
                case '/':
                    try
                    {
                        return number1 / number2;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Division by zero error");
                        return 0;
                    }
                case '*':
                    return number1 * number2;
                default:
                    Console.WriteLine("An unexpected situation occurred.");
                    return 0;
            }
        }

    }
}
