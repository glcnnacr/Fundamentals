using System.Collections;

namespace _13_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Topic Explanation

                /*
                    The arrays we've seen so far have two characteristics:
                    1. Type dependency (all elements must be of the same type).
                    2. Element count dependency (fixed size).
                    
                    ArrayLists eliminate these problems.
                    When we define an ArrayList, we don't have to specify an element count or type.
                    
                    Since ArrayLists accept values of type object, any kind of data can be added. 
                    However, when searching or comparing values, we need to perform unboxing.
                    
                    Disadvantage: While iterating over the data, unboxing must be performed, 
                    which can cause performance loss.
                */

            #endregion
            #region Example 1

                ArrayList arrayList = new ArrayList();
                arrayList.Add(1);
                arrayList.Add("Gulcan");
                arrayList.Add(DateTime.Now);
                arrayList.Add(12.5f);
                arrayList.Add(12.5f);
                decimal total = 0;

                foreach (var item in arrayList)
                    {
                        decimal number;
                        var result = decimal.TryParse(item.ToString(), out number);

                        if (result)
                            {
                                total += number;
                            }
                        Console.WriteLine(item);
                    }
                Console.WriteLine(total);

            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
