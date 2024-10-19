using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _15_BuiltInMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            DateTime startTime = DateTime.Now;

            #region String Built-in Methods

                string sentence = "The M virus is transmitted from rodents like mice and squirrels or from infected individuals. Touching the body rashes caused by the virus, using items such as clothes, sheets, towels contaminated by these rashesand contact with body fluids are among the main causes of transmission.";

                Console.WriteLine($"Length of Sentence: {sentence.Length}");
                Console.WriteLine($"The word 'infected' is at index {sentence.IndexOf("infected")}");

                #region Word Count in Sentence

                    Console.WriteLine($"There are a total of {sentence.Split(' ').Count()} words in the sentence");
                    var sentences = sentence.Split('.');

                    foreach (var item in sentences)
                        {
                        Console.WriteLine(item);
                        }
                
                #endregion
                #region Replace

                    /*                
                        If we want to replace 'mice' with 'rodents' in the sentence
                        the replace method does not modify the original sentence. It returns the modified sentence.
                    */

                    var newSentence = sentence.Replace("mice", "rodents");

                    Console.WriteLine(sentence);
                    Console.WriteLine(newSentence);

                #endregion
                #region Substring => Used to extract a specific part of the sentence.

                    string str = "Today is Friday";
                    Console.WriteLine(str.Substring(6));                                // Gives you everything after the 6th character.
                    Console.WriteLine(str.Substring(6, 9));                             // Starts at the 6th character and takes 9 characters.

                    string creditCardNo = "1234 5678 9123 4567";                        // last four digits of a credit card number
                    Console.WriteLine(creditCardNo.Substring(creditCardNo.Length - 4));

                    string mothersMaidenName = "Smith";                                 // 3rd and 5th characters
                    Console.WriteLine($"{mothersMaidenName[2]} ,{mothersMaidenName[4]} ");

                #endregion
                #region ToLower() ToUpper()

                    Console.WriteLine(str.ToLower());
                    Console.WriteLine(str.ToUpper());

                #endregion
                #region Insert , Remove

                    Console.WriteLine(str.Insert(str.Length, ".The weather is also very hot"));
                    Console.WriteLine(str.Remove(6));
                    Console.WriteLine(str.Remove(6, 9));

                #endregion
                #region IsNullOrEmpty

                    string.IsNullOrEmpty(str);  // Checks whether the string is null or empty

                #endregion
                #region Censorship

                    Console.WriteLine(Censor(sentence));

                #endregion

            #endregion

            #region Math Built-in Methods

                //Power Calculation
                Console.WriteLine(Math.Pow(2, 3)); // 8

                // Square Root Calculation
                Console.WriteLine(Math.Sqrt(16)); // 4

                // Cube Root Calculation
                Console.WriteLine(Math.Pow(8, 1/3.0)); // 2

                // PI
                Console.WriteLine(Math.PI);
                Console.WriteLine(Math.Tau);

            #endregion

            #region Rounding Methods

                //Ceiling => Rounds the decimal number up
                Console.WriteLine("Ceiling :" + Math.Ceiling(10.1));

                // Floor => Rounds the decimal number down
                Console.WriteLine("Floor :" + Math.Floor(10.9));

                // Round => Rounds the decimal number based on the fractional part (up if .5 or more, down otherwise)
                Console.WriteLine("Round :" + Math.Round(10.4));
                Console.WriteLine("Round :" + Math.Round(10.7));
                Console.WriteLine("Round :" + Math.Round(10.51));
                Console.WriteLine("Round :" + Math.Round(11.51));
                Console.WriteLine("Round :" + Math.Round(12.51));
                Console.WriteLine("Round :" + Math.Round(13.51));
                Console.WriteLine("Round :" + Math.Round(14.51));

            #endregion

            #region DateTime Built-in Methods

                var currentDate = DateTime.Now;
                DateTime aDate = DateTime.Now;

                Console.WriteLine("Local Time: " + DateTime.Now);
                Console.WriteLine("UTC Time: " + DateTime.UtcNow);
                Console.WriteLine(currentDate.ToShortDateString());
                Console.WriteLine(currentDate.ToShortTimeString());
                Console.WriteLine(aDate.ToString("dd.MM"));
                Console.WriteLine(aDate.ToString("MM/dd/yyyy"));

                // Defining Birth Date
                DateTime birthDate = new DateTime(1995, 10, 01); 
                DateTime schoolStartDate = birthDate.AddYears(7);
                DateTime middleSchoolDate = schoolStartDate.AddYears(4);
                DateTime highSchoolDate = middleSchoolDate.AddYears(4);

                Console.WriteLine("Gulcan's Birth Day: " + birthDate.DayOfWeek);
                Console.WriteLine("Gulcan's Birth Day is the " + birthDate.DayOfYear + "th day of the year.");

                // Leap Year Check
                Console.WriteLine(DateTime.IsLeapYear(birthDate.Year));

                #region Difference Between Two Dates

                TimeSpan timeSpan = DateTime.Now - birthDate;
                Console.WriteLine("Gulcan has been alive for " + timeSpan.Days + " days");

                TimeSpan performance = DateTime.Now - startTime;
                Console.WriteLine("Program Execution Time: " + performance.TotalNanoseconds);
                Console.WriteLine("Program Execution Time: " + performance.Nanoseconds);

                stopWatch.Stop();
                Console.WriteLine("Milliseconds: " + stopWatch.ElapsedMilliseconds);

                #endregion

            #endregion
        }

        public static string Censor(string sentence)
        {
            string newSentence = "";
            List<string> forbiddenWords = new List<string>();
            forbiddenWords.Add("mice");
            forbiddenWords.Add("body");
            forbiddenWords.Add("touch");

            foreach (var word in forbiddenWords)
                {
                    if (sentence.Contains(word))
                        {
                            string stars = "";

                            for (int i = 0; i < word.Length; i++)
                                {
                                    stars += "*";
                                }

                            sentence = sentence.Replace(word, stars);
                        }
                }

            return sentence;
        }
    }
}
