namespace _8_MainArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
                {
                    Console.WriteLine(item);
                }

            #region Let's take two numbers from the command line and an expression like +, -, /, *

                // We will perform one of the four operations based on the entered expression

            #endregion

            if (args.Length == 0)
                {
                    Console.WriteLine("Program Usage: \n <number1> <number2> <operator>\n Available operators: + - / * ");
                    return;
                }

            if (!(args[2] == "+" || args[2] == "-" || args[2] == "*" || args[2] == "/"))
                {
                    Console.WriteLine("Available operators: + - * / ");
                    return;
                }

            int number1, number2;
            bool result = int.TryParse(args[0], out number1);
            bool result2 = int.TryParse(args[1], out number2);

            if (result == true && result2 == true)
                {
                    switch (args[2])
                        {
                            case "+":
                                Console.WriteLine($"Sum: {number1 + number2}");
                                break;
                            case "-":
                                Console.WriteLine($"Difference: {number1 - number2}");
                                break;
                            case "*":
                                Console.WriteLine($"Product: {number1 * number2}");
                                break;
                            case "/":
                                Console.WriteLine($"Quotient: {number1 / number2}");
                                break;
                            default:
                                Console.WriteLine("An unexpected situation occurred.");
                                break;
                        }
                }
        }
    }
}
