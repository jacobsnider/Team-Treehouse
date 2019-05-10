using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        public static void Main()
        {
            var album1 = new Album("Go To Prison", "Pears");
            var album2 = new Album("Green Star", "Pears");
            var album3 = new Album("Human Movement", "Pears");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());

            album1.Loan("Joe Smith");

            Console.WriteLine(album1.GetDisplayText());

            album1.Return();

            Console.WriteLine(album1.GetDisplayText());
        }
    }
}
