namespace _9_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Topic Explanation

                /*
                    What is a Method: A block of code used to perform a specific function.
                    Types of Methods => Methods that return a value or do not return a value.
                                        If methods do not return a value, they must be marked as void.
                                        If they return a value, the return type must be specified.
                    All methods can be defined with parameters.
                    In other words, you can send as many parameters as you like to a method, provided you specify their types.

                    Benefits: Prevents code repetition and promotes reusability.
                    Improves code readability and makes the program more modular.

                    Declaration Format:

                    [Access Modifier] [Return Type] [MethodName](parameters)
                    {
                    Code here...
                    }

                    [Access Modifier] => Determines who can access the method.
                                        Can take values like public, private, internal, or protected.
                                        Public means it's accessible to everyone. We will use public for now.

                    [Return Type] => If a method doesn't return anything, it should be marked as void.
                                    The return type can be int, float, string, datetime, etc.
                                    If there is a return type, the method must contain a return statement.

                    (parameters) => The data we send to the method. Parameters are separated by commas.
                                    You must specify the types of all parameters that the method will receive.
                    Methods are usually defined within a class.
                */

            #endregion

            #region Method Signature

                /*
                    Methods with the same name can be written as long as they take different parameters.
                    This is called method overloading.

                    The return type of the method is not part of its signature.
                */

            #endregion

            #region Method to Add Two Numbers

                // public static void Add(int number1, int number2)
                // public static long Add(int number1, int number2)

            #endregion

            #region Method Call

                //Add(3, 5);
                //decimal sum = Add(3.5m, 5.3m);
                //Console.WriteLine($"Float Sum: {sum.ToString("0.00")}");

            #endregion

            #region Questions

                /*
                    1- Write a method that prints the received message to the screen (WriteToScreen()).
                    2- Write a method that reads a number from the screen and returns it as an integer (ReadNumber()).
                    3- Write a method that takes two integer values and a string operator, and performs the corresponding arithmetic operation based on the operator provided.
                */

            #endregion

            // int number = Screen.ReadNumber("Enter a number:");
            // double number1 = (double)Screen.ReadNumber("Enter a double number:");
            // double number2 = (double)Screen.ReadNumber("Enter a double number:");
            // Console.WriteLine(Maths.PerformOperation(number1, number2, '*'));

            // Write a method that calculates the factorial of a number.
            //var factorial = Factorial(12);
            //Console.WriteLine(factorial);
            // Write a method that calculates the power of a given number (e.g., long PowerOf(2, 4)).

            long result = Maths.FactorialRecursive(3);
            Console.WriteLine(result);
        }
    }
}
