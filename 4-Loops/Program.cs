using System;

namespace _4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Topic Explanation

                /*
                    There are 3 types of loops:
                    for, while, do-while                     
                    foreach is not a loop; it's an iteration. For foreach to work, 
                    you need a dataset, like an array or a list.
                */

            #endregion

            #region For Loop

                // /*
                //     A for loop requires a starting value, a condition, and an increment.
                //     Syntax: for(initialization; condition; increment)
                // */

                // // 1-10 inclusive numbers
                // for (int i = 0; i < 10; i++)
                //     {
                //         Console.WriteLine(i);
                //     }

                // // 10-20 inclusive numbers
                // for (int i = 10; i <= 20; i++)
                //     {
                //         Console.WriteLine(i);
                //     }

                // // 50 to 20 decreasing
                // for (int i = 50; i >= 20; i--)
                //     {
                //         Console.WriteLine(i);
                //     }

            #endregion

            #region Example 1: What is the sum and average of the first hundred numbers?

                // int total = 0;                
                // for (int i = 0; i <= 100; i++)
                //     {
                //         total += i;
                //     }
                // float average = total / 100f; // This ensures the division is a float
                // Console.WriteLine(average);

            #endregion

            #region Print years from 2015 to 2025, skipping the pandemic year.

                // for (int i = 2015; i < 2026; i++)
                //     {
                //         if (i != 2020)
                //             Console.WriteLine(i);
                //     }

                // //Alternative way using continue
                // for (int i = 2015; i < 2026; i++)
                //     {
                //         if (i == 2020)
                //             continue;
                //         Console.WriteLine(i);
                //     }

                // // Using break to exit the loop
                // for (int i = 2015; i < 2026; i++)
                //     {
                //         if (i == 2020)
                //             break;
                //         Console.WriteLine(i);
                //     }

                // // Using return to exit the program
                // for (int i = 2015; i < 2026; i++)
                //     {
                //         if (i == 2020)
                //             return;
                //         Console.WriteLine(i);
                //     }

                // Console.WriteLine("End of Program");

            #endregion

            #region While Loop

                /*
                    The while loop executes as long as the condition is true.
                    General syntax: 
                    while(condition)
                    {
                        // Code to execute while condition is true
                    }
                */

                #region Sum numbers until 0 is entered

                    // int total = 0, number = 1, counter = 0;
                
                    // while (number != 0)
                    //     {
                    //         Console.Write("Enter a number:");
                    //         number = int.Parse(Console.ReadLine());
                    //         total += number; // total = total + number
                    //         counter++; // counter = counter + 1
                    //     }

                    // Console.WriteLine("Count of entered numbers: " + counter + " Total: " + total);
                    // Console.WriteLine($"Count of entered numbers: {counter} Total: {total}");

                #endregion

                #region Number Guessing Game: A number will be held between 1 and 50. The user gets 5 guesses.

                    // Random rnd = new Random();
                    // string continueGame = "y";

                    // while (continueGame != "n")
                    //     {
                    //         Console.Clear();
                    //         int targetNumber = rnd.Next(1, 50);
                    //         byte guessLimit = 5;
                    //         int guessedNumber = 0;
                    //         do{
                    //                 Console.WriteLine("Enter a number between 1-50:");
                    //                 guessedNumber = int.Parse(Console.ReadLine());
                    //                 guessLimit--;
                    //                 if (guessedNumber == targetNumber)
                    //                 {
                    //                     Console.WriteLine($"Congratulations! You guessed it in {5 - guessLimit} tries.");
                    //                     break;
                    //                 }
                    //                 else if (guessedNumber > targetNumber)
                    //                 {
                    //                     Console.WriteLine("Enter a smaller number.");
                    //                     Console.WriteLine($"Remaining guesses: {guessLimit}");
                    //                 }
                    //                 else
                    //                 {
                    //                     Console.WriteLine("Enter a larger number.");
                    //                     Console.WriteLine($"Remaining guesses: {guessLimit}");
                    //                 }
                    //             } while (guessLimit > 0);

                    //         Console.WriteLine("Do you want to continue? [y/n]");
                    //         continueGame = Console.ReadLine().ToLower();
                    //     }

                #endregion

                #region Fibonacci Series: The series is defined as 1, 1, 2, 3, 5, 8, 13, 21, 34...

                    // // Print the first 20 Fibonacci numbers.

                    // int number1 = 1, number2 = 0, sum;
                    // for (int i = 1; i < 21; i++)
                    //     {                            
                    //         sum = number1 + number2;
                    //         Console.Write(sum + " ");
                    //         number1 = number2;
                    //         number2 = sum;
                    //     }

                #endregion

                #region Print the first 20 prime numbers

                    // int count = 1, innerCount = 0;

                    // for (int i = 1; i < 1000; i++)
                    //     {
                    //         for (int j = 1; j <= i; j++)
                    //             {
                    //                 if (i % j == 0)
                    //                     {
                    //                         innerCount++;
                    //                     }
                    //             }

                    //         if (innerCount == 2)
                    //             {
                    //                 Console.WriteLine(i);
                    //                 count++;
                    //             }

                    //         innerCount = 0;
                    //         if (count == 20) break;
                    //     }

                    
                #endregion

            #endregion
        
        }
    }
}
