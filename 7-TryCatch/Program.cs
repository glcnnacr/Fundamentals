namespace _7_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explanation 

            /*
                try-catch is a structure used for error handling.

                Errors can be categorized into three main headings:
                   1- Syntax errors (Usually caught by the IDE which highlights the error before compilation)
                   2- Runtime errors (Errors that occur during execution)
                       Division by zero, type conversion errors, 
                       input-output errors, etc.
                   3- Logic errors => Errors made by programmers.
                      These are harder to detect and resolve.
                      They can be resolved through debugging.

                  Usage
                  try
                  {
                     Code to be executed goes here
                  }
                  catch (Exception ex)
                  {
                    Actions to be taken after the error is caught go here
                  }
                  finally
                  {
                     This block will always be executed, whether an error occurs or not
                  }
            */

            #endregion

            #region Example: Division of Two Numbers

                // try
                //     {
                //     int number1, number2;
                //     Console.WriteLine("Please enter the first number:");
                //     number1 = int.Parse(Console.ReadLine());
                //     Console.WriteLine("Please enter the second number:");
                //     number2 = int.Parse(Console.ReadLine());
                //     Console.WriteLine($"Quotient: {number1 / number2}");
                //     }

                // catch (DivideByZeroException ex)
                //     {
                //     Console.WriteLine("A division by zero error occurred.");
                //     }

                // catch (FormatException ex)
                //     {
                //     Console.WriteLine("Please enter a number in the correct format.");
                //     }
                // catch (OverflowException ex)
                //     {
                //     Console.WriteLine("Overflow error. You entered a very large number.");
                //     }
                // catch (Exception ex) // If you catch Exception, this should be the last one.
                //     {
                //     Console.WriteLine("An unknown error occurred.");
                //     }

            #endregion

            #region Controlled Number Conversion

                // int num1, num2;
                // float fNum;
                // double dNum;
                // DateTime date;
                // bool result1, result2;

                // Console.WriteLine("Please enter the first number:");
                // result1 = int.TryParse(Console.ReadLine(), out num1);

                // Console.WriteLine("Please enter the second number:");
                // result2 = int.TryParse(Console.ReadLine(), out num2);

                // if (result1 == true && result2 == true)
                //     {
                //         Console.WriteLine("Sum: " + (num1 + num2));
                //     }

                // result1 = float.TryParse(Console.ReadLine(), out fNum);
                // Console.WriteLine("Float: " + fNum.ToString("0.00"));

                // result1 = double.TryParse(Console.ReadLine(), out dNum);
                // Console.WriteLine("Decimal: " + dNum.ToString("0.00"));

                // result1 = DateTime.TryParse("01.01.2000", out date);
                // Console.WriteLine("Date: " + date);

            #endregion
        }
    }
}
