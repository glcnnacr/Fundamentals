namespace TypeConversions;

class Program
{
    static void Main(string[] args)
    {
        /*
        Example:
        Let's add two numbers read from the screen
        */

        byte bNumber;            Byte bNumber2;
        sbyte sbyte1;            SByte sbyte2;
        short x, y;              Int16 a, b; // short
        int number1, number2;    Int32 number3, number4;
        float fNumber1;          Single fNumber2;
        long longNumber;         Int64 longNumber2;
        decimal dNumber;         Decimal dNumber2;
        double doubleNumber;     Double doubleNumber2;
        string input1, input2;

        // To read a value from the screen, the Console.ReadLine() method is used
        Console.WriteLine("Enter the first number:");
        input1 = Console.ReadLine();

        // Type conversion method 1: Using the Convert class
        number1 = Convert.ToInt32(input1);

        // Method 2
        number1 = int.Parse(input1);

        x = (short)number1; // Cast, request to convert to a smaller type
        doubleNumber = number1;
        number2 = (int)doubleNumber;

        Console.WriteLine("Enter the second number:");
        input2 = Console.ReadLine();
        number2 = int.Parse(input2);

        System.Console.WriteLine("String concatenation: " + input1 + input2);
        System.Console.WriteLine("Numeric sum: " + (number1 + number2));
       
        Console.WriteLine("Hello, World!");
        
    }
}
