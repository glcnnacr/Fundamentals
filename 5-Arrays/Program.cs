using _16_MyLibrary;
using _16_MyLibrary.SayisalKutuphaneler;

namespace _5_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            #region Topic Explanation

                /*
                    Arrays are objects that allow us to hold multiple data of the same type together.
                    The number of elements in arrays is fixed.
                    It cannot be changed later.

                    Index always starts from 0.

                    Common error: Index was outside the bounds of the array
                    This error indicates that an operation is being performed outside the number of elements in the array.


                    Declaration Rule: <data type>[] arrayName;
                                        int[] numbers;
                                        DateTime[] dates;
                                        bool[] test;
                */
            
            #endregion

            #region Array Declaration and Value Assignment

                //int[] grades; // Here the array is declared, but the number of elements is not specified.
                //int[] numbers = new int[10]; // This is a 10-element array. Default values are 0.
                //int[] numbers2 = {0,1,2,3,4,5,6,7,8,9}; // This is a 10-element array with initial values.


                // To assign values one by one, array index is used
                //numbers2[3] = 20; // Here the 4th element is assigned a value of 20.

                /* All the loops we know are valid for printing arrays to the screen.
                    Usually, for loop is used.
                    However, foreach is also often used.
                    Foreach is not a loop. It is an iteration.
                    The difference is, for example, we cannot print numbers between 1-10 using foreach.
                    For foreach, a data set is required, which can be either an array or a list.
                */

                //for (int i = 200; i > 100; i--)
                //    {

                //    }

                #region var keyword
                    /*
                        var is similar to var in JavaScript.
                        The data type is determined at runtime.
                        Once the data type is determined, another data type cannot be assigned.
                    */

                    //var temp = DateTime.Now;
                    //temp = "John Doe"; // This will give an error.

                #endregion

                // Using foreach 

                    //foreach (var item in numbers2)
                    //    {
                    //        Console.WriteLine(item);
                    //    }

                //Using for

                    //for (int i = 0; i < numbers2.Length; i++)
                    //    {
                    //        Console.WriteLine(numbers2[i]);
                    //    }

            #endregion

            #region Assign random grades for a class of 20 students

                // int[] grades = new int[20];
                // Random rnd = new Random();

                // You cannot assign values while iterating with foreach. 
                // This is a common mistake.

                //foreach (var item in grades)
                //    {
                //        item = rnd.Next(20, 100);
                //    }

                // Using for loop

                //for (int i = 0; i < grades.Length; i++)
                //    {
                //        grades[i] = rnd.Next(20, 100);
                //    }

                //foreach (var item in grades)
                //    {
                //        Console.WriteLine(item);
                //    }

            #endregion

            #region Different perspective on strings

                //string str = "Besiktas";

                //for (int i = 0; i <str.Length; i++)
                //    {
                //        Console.WriteLine(str[i]);
                //    }

                //foreach (char ch in str)
                //    {
                //        Console.WriteLine(ch);
                //    }

            #endregion

            #region Multidimensional Arrays

                /*
                    For a two-dimensional array: int[,] matrix = new int[2,3];
                    For a three-dimensional array: int[,,] cube = new int[3,3,3];
                */

                //int[,] matrix = new int[3, 3];
                //Console.WriteLine($"First Dimension of Matrix: {matrix.GetLength(0)}\nSecond Dimension of Matrix: {matrix.GetLength(1)}");

                //for (int i = 0; i < matrix.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < matrix.GetLength(1); j++)
                //            {
                //                matrix[i, j] = rnd.Next(100);
                //            }
                //    }

                //for (int i = 0; i < matrix.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < matrix.GetLength(1); j++)
                //            {
                //                Console.WriteLine(matrix[i, j]);
                //            }
                //    }

                #region Create an array to hold 2 midterms and 1 final grade for 20 students

                    //int[,] grades2 = new int[20, 3];

                    //for (int i = 0; i < grades2.GetLength(0); i++)
                    //    {
                    //        for (int j = 0; j < grades2.GetLength(1); j++)
                    //            {
                    //                grades2[i,j]=rnd.Next(20,50);
                    //            }
                    //    }

                    // Midterms are 30% and the final is 70%.
                    // Scores above 50 will pass.
                    // Print the pass/fail status of students in this array.

                    //0 => 20,40,60 Average: 

                    //double average;
                    //for (int i = 0; i < grades2.GetLength(0); i++)
                    //    {
                    //        average = grades2[i, 0] * 0.15 + grades2[i, 1] * 0.15 + grades2[i, 2] * 0.7;

                    //        Console.WriteLine($"{i}. Student Midterm1: {grades2[i, 0]} Midterm2: {grades2[i, 1]} Final: {grades2[i, 2]}  Average: {average.ToString("0.00")} Result: " + (average>=50?"Passed":"Failed"));
                    //    }

                #endregion

            #endregion

            #region Find the smallest and largest element in the array

                //int[] numbers = new int[20];

                //for (int i = 0; i < numbers.Length; i++)
                //    {
                //        numbers[i] = rnd.Next(1,100);
                //        Console.WriteLine(numbers[i]);
                //    }

                //Console.WriteLine("********************");
                //Console.WriteLine(numbers.Max());
                //Console.WriteLine(numbers.Min());

            #endregion

        }
    }
}

