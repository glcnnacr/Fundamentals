using System.Data;
using System.Globalization;

namespace _10_MethodsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Questions

            /*
                1- CalculateVAT(100, 20, true) => 83.33 
                   CalculateVAT(100, 20, false) => 120

                2- CalculateSpeed(100km, 30 minutes) => You need to go at 200 km/h   


                3 -CreateArray(elementCount) => returns an array of random numbers between 1-100 of type int

                4- GetCity(0) => returns a random city.
                   GetCity(34) => returns Istanbul.

                5- CountVowels(string) => "There are 5 vowels. a, e, i" as output.

                6- Encrypt(string) => prints encrypted text. Decrypt(encrypted) => original word

                7- Method that prints the digits of an integer entered from the keyboard. FindDigits(int) 
            */

            string[] cities = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
            "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul", "Izmir",
            "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

            #endregion


            cities.Where(p => p.Contains("A"));

            CalculateVAT(100, 20, false);

            CalculateSpeed(60, 30);

            var array = CreateArray(10);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            FindCity(cities, 0);

            CountVowels("Today is Thursday");

            Console.WriteLine("Lütfen şifrelenecek bir cümle giriniz:");
            string inputSentence = Console.ReadLine();
            Encrypt(inputSentence);
            Console.WriteLine();

            FindDigits();

            Sum('+', 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 33);
        }

        public static void Sum(char operation, params int[] numbers)
        {
            int total = 0;
            if (operation == '+')
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }
            }
        }
        public static void Sum(int num1, int num2)
        {

        }
        public static void Sum(int num1, int num2, int num3)
        {

        }
        public static void Sum(int num1, int num2, int num3, int num4)
        {

        }
        
        
        
        #region Example-1 CalculateVAT
            public static void CalculateVAT(double amount, double vat, bool isIncluded)            
                {
                    if (isIncluded)
                        {
                            double vatAmount = amount * vat / 100;
                            Console.WriteLine($"VAT Amount: {vatAmount}");
                            Console.WriteLine($"Total Amount: {amount + vatAmount}");
                        }
                    else
                        {
                            double vatExclusiveAmount = amount / ((100 + vat) / 100);
                            Console.WriteLine("Price: " + amount);
                            Console.WriteLine($"VAT Exclusive Amount: {vatExclusiveAmount}");
                            Console.WriteLine($"VAT Amount: {amount - vatExclusiveAmount}");
                        }
                }

       #endregion

        #region Example-2 CalculateSpeed
        public static void CalculateSpeed(int distance, int minutes)
            {
                Console.WriteLine($"To cover {distance} km in {minutes} minutes, you need to travel at {distance * (60 / minutes)} km/h.");
            }

    #endregion
    
        #region Example-3 CreateArray
            public static int[] CreateArray(int elementCount)
                {
                    int[] array = new int[elementCount];
                    Random rnd = new();

                    for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = rnd.Next(1, 100);
                        }

                    return array;
                }

        #endregion

        #region Example-4 FindCity
            public static void FindCity(string[] cities, byte code)
                {
                    Random rnd = new();

                    if (code == 0)
                        {
                            Console.WriteLine(cities[rnd.Next(1, cities.Length)]);
                        }
                    else
                        {
                            Console.WriteLine(cities[code - 1]);
                        }
                }

        #endregion

        #region Example-5 CountVowels
            public static void CountVowels(string sentence)
                {
                    // sentence = "Today is Thursday";
                    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                    int counter = 0;

                    foreach (var letter in sentence)
                        {
                            for (int i = 0; i < vowels.Length; i++)
                                {
                                    if (letter == vowels[i]) counter++;
                                }
                        }

                    Console.WriteLine(sentence);
                    Console.WriteLine("Number of vowels found: " + counter);
                }

        #endregion

        #region Example-6 Encrypt
        public static void Encrypt(string inputSentence)
            {
                char[] hashedSentence = new char[inputSentence.Length];

                for (int i = 0; i < inputSentence.Length; i++)
                    {
                        hashedSentence[(inputSentence.Length - 1) - i] = inputSentence[i];
                    }
                foreach (var item in hashedSentence)
                    {
                        Console.Write(item);
                    }
            }

        #endregion

        #region Example-7 FindDigits
        public static void FindDigits()
            {
                Console.WriteLine("Please enter an integer:");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());
                int digitPosition = 1;

                while (enteredNumber > 0)
                    {
                        int digit = enteredNumber % 10;
                        Console.WriteLine($"{digitPosition}. digit value: {digit}");
                        digitPosition++;
                        enteredNumber = enteredNumber / 10;
                    }
            }

        #endregion
    }
}
