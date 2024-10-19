using System;
using System.Runtime.InteropServices;

namespace DefiningVariables
{
   
    public class Program
    {
        static int age =20;
        
        public static void Main(string[] args)
        {
            #region Range of values of the variables

            System.Console.WriteLine("Size of Variables");
            System.Console.WriteLine("Byte ......");// byte
            System.Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
            
            System.Console.WriteLine("short ......"); //short
            System.Console.WriteLine(short.MinValue + " " + short.MaxValue);
     
            System.Console.WriteLine("unsign short ......");// ushort
            System.Console.WriteLine(ushort.MinValue + " " + ushort.MaxValue);

            System.Console.WriteLine("int  ......"); // int
            System.Console.WriteLine(int.MinValue + " " + int.MaxValue);
            System.Console.WriteLine("uint  ......");
            System.Console.WriteLine(uint.MinValue + " " + uint.MaxValue);

            System.Console.WriteLine("long  ......");// long
            System.Console.WriteLine(long.MinValue + " " + long.MaxValue);
            System.Console.WriteLine("ulong  ......");
            System.Console.WriteLine(ulong.MinValue + " " + ulong.MaxValue);


        // Fractional values: float (4 byte), double (8 byte), decimal (16 byte)

            System.Console.WriteLine("float  ......");// long
            System.Console.WriteLine(float.MinValue + " " + float.MaxValue);

            System.Console.WriteLine("double  ......");// long
            System.Console.WriteLine(double.MinValue + " " + double.MaxValue);
           
            System.Console.WriteLine("decimal  ......");// long
            System.Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
            
            #endregion

            #region Rules for the definition of variables

                /*
                *  1- Variable names cannot start with a number.
                *  2- Reserved words cannot be used (e.g., static, void, public, etc.).
                *  3- Only the underscore (_) special character can be used.
                *  4- Variable names can have a maximum of 255 characters.
                *  5- <Type> <variableName> = <initialValue>;
                */

                // Principles for variable names consisting of multiple words
                // int StockQuantity  => Pascal Case
                // int stockQuantity  => Camel Case
                // int stock_quantity => Snake Case
                // int stock-quantity => Kebab Case

            #endregion

            #region Example

                // Let's define variables to represent a student's first name, last name, date of birth, shoe size,
                // ID number (TC No), and mobile number (GSM).

                string firstName="Gul", lastName="Acar";
                DateTime dateOfBirth = new DateTime(1995, 10, 1);
                DateTime today = DateTime.Now;// Assignment of the initial value
                byte shoeSize=38;
                string tcNo = "12345678901";
                System.Console.WriteLine(tcNo.Substring(7));
                //tcNo.ToString().Substring(8,11);

                string gsm="+90 512 345 67 89";

                Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Date of Birth: {dateOfBirth.ToShortDateString()}, Today's Date: {today}, Shoe Size: {shoeSize}, TC No (last 4 digits): {tcNo.Substring(7)}, GSM: {gsm}");

            #endregion

            #region Determine the type at runtime
            
            var temp = "12";
            System.Console.WriteLine(temp);
                
            #endregion

            #region Fractional Numbers

                var number = 12.3; // Defaults to double; use 'f' for float and 'm' for decimal

                System.Console.WriteLine(number);

            #endregion 

            #region Constants

                const float pi = 3.14F;
                //pi = 4.56f; Values cannot be reassigned to const variables

                System.Console.WriteLine(pi);

            #endregion

            #region Variable Lifespan
            {
                string email = "gul@gmail.com";
                System.Console.WriteLine(age);
                System.Console.WriteLine(email);  
                {
                    int number1 = 10;
                    System.Console.WriteLine(age);
                    System.Console.WriteLine(email);
                    System.Console.WriteLine(number1);
                }  
                // System.Console.WriteLine(number1); This will cause an error
            }
                // System.Console.WriteLine(email); This will cause an error
                // System.Console.WriteLine(number1); This will cause an error
            #endregion
            
            #region Nullable Variable Declaration and ?
                            
                // To allow a variable to have null values, it must be marked with a '?'.
                string? city = "";

            #endregion

            
            Console.WriteLine("Hello, World!");
        }
    }
}