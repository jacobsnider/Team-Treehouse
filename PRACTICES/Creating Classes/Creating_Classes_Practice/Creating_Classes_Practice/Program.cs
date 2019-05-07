using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        public static void Main()
        {
            var album = new Album("Go To Prison", "Pears");
            var movie = new Movie("Monty Python and the Holy Grail", "Terry Jones & Terry Gilliam");
            var book = new Book("Catcher in the Rye", "J.D. Salinger");

            Console.WriteLine("Album: " + album.Title + " by " + album.Artist );
            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
            Console.WriteLine("Album: " + book.Title + " by " + book.Author);

            album.Title = "Green Star";

            Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
        }
    }
}
