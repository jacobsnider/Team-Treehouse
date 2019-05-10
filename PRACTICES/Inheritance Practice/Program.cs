using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        public static void Main()
        {

            try 
            {
                var album1 = new Album("Go To Prison", "Pears");
                var album2 = new Album("Green Star", "Pears");
                var album3 = new Album("Human Movement", "Pears");
                var book = new Book("Catcher in the Rye", "J.D. Salinger");
                var movie = new Movie("Monty Python and the Holy Grail", "Terry Gilliam and Terry Jones");

                DetectMediaType(album1);
                DetectMediaType(album2);
                DetectMediaType(album3);
                DetectMediaType(book);
                DetectMediaType(movie);

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(album3.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                album1.Loan("Joe Smith");
                album1.Loan();
                book.Loan();
                movie.Loan();

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                album1.Return();
                album2.Return();
                book.Return();
                movie.Return();

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void DetectMediaType(MediaType item)
        {
            if (item is Album) 
            {
                Console.WriteLine(item.Title + " is an album!");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a book!");
            }
            //else if (item is Movie)
            //{
            //    Console.WriteLine(item.Title + " is a movie!");
            //}
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
