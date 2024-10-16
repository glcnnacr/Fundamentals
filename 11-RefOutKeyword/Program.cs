namespace _11_RefOutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Topic Explanation 

            /*
                The ref and out keywords work similarly to pointers in C.
                They allow passing value-type variables by reference to methods.
             
                When using ref, an initial value must be assigned.
                For out, an initial value is not required.
             
                A parameter marked with out must be assigned a value inside the method.
            */

            #endregion

            #region Out Example

                //int result = 12;
                //bool isSuccess = int.TryParse("5", out result);
                //Console.WriteLine(TryParseNumber("30", out result));
                //int sum, difference;
                //long product;
                //double quotient;
                //BasicOperations(3, 5, out sum, out difference, out product, out quotient);
                //Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}");

            #endregion

            #region Ref Example 

                int a = 2;
                //int total = TestAddition(5, ref a);
                // Console.WriteLine(total);
                int[] numbers = { 1, 2, 3, 4, 5, 6 };
                IncreaseArraySize(ref numbers, 10);
                Console.ReadKey();

            #endregion
        }

        public static void IncreaseArraySize(ref int[] numbers, int newSize)
            {
                int[] newArray = new int[newSize];
                for (int i = 0; i < numbers.Length; i++)
                {
                    newArray[i] = numbers[i];
                }
                numbers = newArray;
            }

        public static int TestAddition(int number1, ref int number2)
            {
                number2 = 5;
                return number1 + number2;
            }

        public static bool TryParseNumber(string value, out int result)
            {
                // The out parameter must be assigned a value inside the method.
                try
                    {
                        result = int.Parse(value);
                        return true;
                    }
                catch (Exception ex)
                    {
                        result = 0;
                        return false;
                    }
            }

        public static bool BasicOperations(int number1, int number2, out int sum, out int difference, out long product, out double quotient)
            {
                sum = number1 + number2;
                difference = number1 - number2;
                product = number1 * number2;

                    if (number2 == 0)
                        {
                            quotient = 0;
                            return false;
                        }

                quotient = (double)number1 / number2;
                return true;
            }
    }
}
