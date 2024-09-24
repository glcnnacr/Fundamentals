namespace _2_IfElse;

class Program
{
    static void Main(string[] args)
    {

        #region If Statement Explanation with Example

            int number1 = 5;
            int number2 = 5;

            if (number1 == 5) 
            {
                // If true, execute this block
            }
            else
            {
                // If false, execute this block
            }

            /* Common mistakes:
            
                if (number > 10); => Semicolon should not be placed here
                {
                    // Correct
                }
                else
                {
                    // Incorrect
                }
            */

            if (number1 > number2)
            {
                System.Console.WriteLine(number1 + " > " + number2);  
            }
            else if (number1 == number2)
            {
                System.Console.WriteLine(number1 + " = " + number2);
            }
            else
            {
                System.Console.WriteLine(number1 + " < " + number2);
            }

        #endregion

        #region Water Temperature

        /*
            Based on the entered water temperature, display its state: solid, liquid, or gas.
        */

            Int16 waterTemperature;
            string temp;
            System.Console.WriteLine("Enter the water temperature:");

            temp = Console.ReadLine();
            waterTemperature = Convert.ToInt16(temp);

            if (waterTemperature <= 0)
                {
                    System.Console.WriteLine("Solid");
                }
            else if (waterTemperature >= 100)
                {
                    System.Console.WriteLine("Gas");
                }
            else 
                {
                    System.Console.WriteLine("Liquid");
                }

        #endregion

        #region Days of the Week

            /*
            Starting with Monday as the 1st day of the week,
            Read the day of the week from the screen.
            Print the corresponding day: 
            1 => Monday, 2 => Tuesday ... 7 => Sunday
            */

            byte day;
            System.Console.WriteLine("Enter the day:");
            day = byte.Parse(Console.ReadLine());

            if (day == 1)
                {
                    System.Console.WriteLine("Monday");
                }
            else if (day == 2)
                {
                    System.Console.WriteLine("Tuesday");
                }
            else if (day == 3)
                {
                    System.Console.WriteLine("Wednesday");
                }
            else if (day == 4)
                {
                    System.Console.WriteLine("Thursday");
                }
            else if (day == 5)
                {
                    System.Console.WriteLine("Friday");
                }
            else if (day == 6)
                {
                    System.Console.WriteLine("Saturday");
                }
            else if (day == 7)
                {
                    System.Console.WriteLine("Sunday");
                }
            else
                {
                    System.Console.WriteLine("Please enter a number between [1-7]");
                }

        #endregion

        #region Final Grade Calculation

            /*
                2 midterms and 1 final will be taken. 30% of the average will come from the midterms, and 70% from the final. Based on the result:
                If 0-29   => D
                   30-49  => C
                   50-69  => B
                   70-100 => A                
                && => and, || => or
            */

            byte midterm1, midterm2, final;
            float average;

            System.Console.WriteLine("Enter the 1st midterm grade:");
            midterm1 = byte.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the 2nd midterm grade:");
            midterm2 = byte.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the final grade:");
            final = byte.Parse(Console.ReadLine());

            average = (midterm1 + midterm2) / 2 * 0.3f + final * 0.7f;

            if (average > 0 && average < 30)
                {
                    System.Console.WriteLine("D: " + average);
                }
            else if (average >= 30 && average < 50)
                {
                    System.Console.WriteLine("C: " + average);
                }
            else if (average >= 50 && average < 70)
                {
                    System.Console.WriteLine("B: " + average);
                }
            else if (average >= 70 && average <= 100)
                {
                    System.Console.WriteLine("A: " + average);
                }
            else
                {
                    System.Console.WriteLine("An invalid value was generated. Please check the grades.");
                }

        #endregion

        #region Ternary IF

            /*
                If we want to proceed with a small decision mechanism in a single line, we need to use the ? operator.
                Syntax: result = condition > 10 ? "True" : "False";
                It is commonly used to check values coming from a database or an API,
                or when assigning a value to a variable.
            */

            int age = 20;
            var conclusion = age > 18 ? "Adult" : "Not an Adult";
            Console.WriteLine(conclusion);

            string result;

            if (age > 18)
                {
                    result = "Adult";
                }
            else         
                {
                    result = "Not an Adult";        
                }

        #endregion

        #region Switch Case
            /*
                It works with the same logic as if-else.
                While if-else checks conditions like greater than, less than, or equality,
                switch-case looks only for equality.
                It has an internal indexing mechanism.
                In cases where there are many equality conditions, switch-case is recommended for better performance.
            */

                byte dayOfWeek;
                System.Console.WriteLine("Enter the day:");
                dayOfWeek = byte.Parse(Console.ReadLine());

            #region Days of the Week  -  IfElse

                if (dayOfWeek == 1)
                    {
                        System.Console.WriteLine("Monday");
                    }
                else if (dayOfWeek == 2)
                    {
                        System.Console.WriteLine("Tuesday");
                    }
                else if (dayOfWeek == 3)
                    {
                        System.Console.WriteLine("Wednesday");
                    }
                else if (dayOfWeek == 4)
                    {
                        System.Console.WriteLine("Thursday");
                    }
                else if (dayOfWeek == 5)
                    {
                        System.Console.WriteLine("Friday");
                    }
                else if (dayOfWeek == 6)
                    {
                        System.Console.WriteLine("Saturday");
                    }
                else if (dayOfWeek == 7)
                    {
                        System.Console.WriteLine("Sunday");
                    }
                else
                    {
                        System.Console.WriteLine("Please enter a number between [1-7]");
                    }

            #endregion

            #region Days of the Week  -  SwitchCase
            
                    switch (dayOfWeek)
                        {
                            case 1:
                                System.Console.WriteLine("Monday");
                                break;
                            case 2: // If multiple lines of code will be written, they can be placed within {}
                                {
                                    System.Console.WriteLine("Tuesday");
                                }
                            break;
                            case 3:
                                System.Console.WriteLine("Wednesday");
                                break;
                            case 4:
                                System.Console.WriteLine("Thursday");
                                break;
                            case 5:
                                System.Console.WriteLine("Friday");
                                break;
                            case 6:
                                System.Console.WriteLine("Saturday");
                                break;
                            case 7:
                                System.Console.WriteLine("Sunday");
                                break;
                        
                            default:
                                Console.WriteLine("Please enter a number between [1-7]");
                                break;
                        }

            #endregion

        #endregion

        /*
            Inside a switch statement, the data type must be consistent in the case checks.
            This is one of the most common mistakes.
        */    

        #region Example 1: Read the season from the screen and print the months. This will be done using switch-case

            Console.WriteLine("Enter the season:");
            string season = Console.ReadLine().ToLower();
            char letter = 'A';
            
            switch (season)
            {
                case "winter":
                    Console.WriteLine("December, January, February");
                    break;
                case "spring":
                    Console.WriteLine("March, April, May");
                    break;
                case "summer":
                    Console.WriteLine("June, July, August");
                    break;
                case "autumn":
                    Console.WriteLine("September, October, November");
                    break;
                default:
                    Console.WriteLine("Please enter a valid season name.");
                    break;
            }
        #endregion

        #region Example 2: Read Role from the Screen. If "Admin" is entered, redirect to the Admin page. 
            /*
                If "Sales" is entered, redirect to the Sales page. 
                If "Member" is entered, display a message indicating you are being redirected to the Member page.
            */

            Console.WriteLine("Enter Role:");
            string role = Console.ReadLine().ToLower();

                // admin, ceo, moderator
                // sales, finance, logistics
                // member, user

            switch (role)
                {
                    case "admin":
                    case "ceo":
                    case "moderator":
                        Console.WriteLine("Redirecting to Admin Page");
                        break;
                    case "sales":
                    case "finance":
                    case "logistics":
                        {
                        Console.WriteLine("Redirecting to Sales Page");
                        }
                        break;
                    case "member":
                    case "user":
                        Console.WriteLine("Redirecting to Member Page");
                        break;
                    default:
                        Console.WriteLine("Invalid role entered.");
                        break;
                }
        #endregion

        #region Example 3: Read Username and Password. 

            /*
                If both are correct, display a welcome message for the admin. 
                If any of the entered information is incorrect, display a clear message indicating which one is wrong.
            */

            Console.WriteLine("Username:");
            string username = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine().ToLower();

            switch (username)
                {
                    case "admin":
                        switch (password)
                            {
                                case "admin":
                                    Console.WriteLine("Welcome Admin");
                                    break;
                                default:
                                    Console.WriteLine("Username correct, Password incorrect");
                                    break;
                            }
                        break;
                    default:
                        switch (password)
                            {
                                case "admin":
                                    Console.WriteLine("Password correct, Username incorrect");
                                    break;
                                default:
                                    Console.WriteLine("Neither of the entered details is correct");
                                    break;
                            }
                        break;
                }

        #endregion

        Console.WriteLine("Hello, World!");
    }
}
