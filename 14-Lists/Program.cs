using System.Collections;
using System.Linq;

namespace _14_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Topic Explanation

                /*
                    Lists are the generic version of ArrayLists where the type is specified.
                    Like ArrayLists, they have a dynamic structure that grows as needed.
                    Unlike arrays, there's no need to specify the number of elements initially.
                    Also, unlike ArrayLists, Lists work with a defined type instead of accepting objects.
                */

            #endregion

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(DateTime.Now);

            // Example of List declarations
            List<string> cities = new List<string>() { "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul",  "Hatay","Izmir" };
            List<DateTime> dateList = new List<DateTime>();
            List<int> numbers = new List<int>();
            
            // Adding elements to the list using the Add method
            numbers.Add(1);
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);

            dateList.Add(DateTime.Now);
            dateList.Add(DateTime.Now.AddYears(-10));
            dateList.Add(DateTime.Now.AddYears(-20));
            dateList.Add(DateTime.Now.AddYears(-30));

            // Removing elements from the list using the Remove method
            // It removes the first occurrence it finds.
            numbers.Remove(1);

            #region Most Common Methods

                // Contains
                cities.Contains("Hatay"); // Doesn't return the index, only checks if the element exists.

                Console.WriteLine(cities.IndexOf("Hatay")); // Returns the first index it finds.
                Console.WriteLine(cities.LastIndexOf("Hatay")); // Returns the last index it finds.
                
                
                // ForEach with Lambda Expression
                cities.ForEach(s => Console.WriteLine(s));

                // Max, Min, Avg, Sum methods

                #region Min Max in Integer Lists

                    Console.WriteLine("Max:" + numbers.Max());
                    Console.WriteLine("Min:" + numbers.Min());
                    Console.WriteLine("Avg:" + numbers.Average());

                #endregion

                #region Min Max in String Lists

                    Console.WriteLine("Max:" + cities.Max());
                    Console.WriteLine("Min:" + cities.Min());
                    // Console.WriteLine("Avg:" + cities.Average());

                #endregion

                #region Min Max in DateTime Lists

                    Console.WriteLine("Max:" + dateList.Max());
                    Console.WriteLine("Min:" + dateList.Min());

                #endregion

                #region Sorting Methods

                    numbers.Sort(); // Ascending order
                    numbers.ForEach(s => Console.WriteLine(s));
                    Console.WriteLine("*********************");
                    numbers.Reverse(); // Descending order
                    numbers.ForEach(s => Console.WriteLine(s));

                #endregion

            #endregion

                Random rnd = new Random();
                for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = rnd.Next(1, 100);
                    }
                    
            Console.WriteLine("Hello, World!");
        }
    }
}
