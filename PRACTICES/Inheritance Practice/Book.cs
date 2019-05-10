using System;
namespace Treehouse.MediaLibrary
{
    public class Book : MediaType
    {
        public readonly string Author;

        public Book(string title, string author)
            : base(title)
        {
            Athour = author;
        }
        public string GetDisplayText()
        {
            string text = "Book: " + Title + "by" + Author;

            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan.)";
                }

            }

            return text;
        }
    }
}
