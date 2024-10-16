namespace _12_ArrayClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Topic Explanation

                /*
                    The Array class is a class written by Microsoft 
                    that makes it easier for us to work with arrays.         
                */

            #endregion

            int[] numbers = { 11, 21, 13, 41, 15, 61, 17 };
            string[] cities = {"Adana", "Adiyaman", "Afyon", "Agri", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydin", "Balikesir", "Bilecik", "Bingol", "Bitlis", "Bolu", "Burdur", "Bursa", "Canakkale",
            "Cankiri", "Corum", "Denizli", "Diyarbakir", "Edirne", "Elazig", "Erzincan", "Erzurum", "Eskisehir",
            "Gaziantep", "Giresun", "Gumushane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul", "Izmir",
            "Kars", "Kastamonu", "Kayseri", "Kirklareli", "Kirsehir", "Kocaeli", "Konya", "Kutahya", "Malatya",
            "Manisa", "Kahramanmaras", "Mardin", "Mugla", "Mus", "Nevsehir", "Nigde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdag", "Tokat", "Trabzon", "Tunceli", "Sanliurfa", "Usak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kirikkale", "Batman", "Sirnak",
            "Bartin", "Ardahan", "Igdir", "Yalova", "Karabuk", "Kilis", "Osmaniye", "Duzce"};
            
            string[] newCities = { "Siirt", "Sinop", "Sivas", "Tekirdag", "Tokat", "Sinop", "Trabzon", "Tunceli" };

            #region Sorting

                Array.Sort(numbers);
                foreach (var item in numbers)
                    {
                        Console.Write(item + " ");
                    }

            #endregion
            #region Clear

                Array.Clear(numbers, 0, 2);
                foreach (var item in numbers)
                    {
                        Console.Write(item + " ");
                    }

            #endregion
            #region Copy Copies from one array to another.

                Array.Copy(cities, newCities, 4);
                foreach (string s in newCities)
                    {
                        Console.WriteLine(s);
                    }

            #endregion
            #region Resize => Changes the size of the array

                Array.Resize(ref numbers, 20);

            #endregion
            #region Fill => Fill

                Array.Fill(newCities, "Batumi");
                foreach (var item in newCities)
                    {
                        Console.WriteLine(item);
                    }

            #endregion
            #region Reverse => Reverses the array
                Array.Reverse(newCities);
                foreach (var item in newCities)
                    {
                        Console.WriteLine(item);
                    }
            #endregion
            #region IndexOf => Returns the index of the searched element in the array.

                /*
                    If it doesn't find the value, it returns -1.
                    If it finds the value multiple times, it returns the index of the first occurrence.
                */

                int index = Array.IndexOf(newCities, "Sinop");
                Console.WriteLine(index);

            #endregion
            #region LastIndexOf
            
                int index1 = Array.LastIndexOf(newCities, "Sinop");
                Console.WriteLine(index1);

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
