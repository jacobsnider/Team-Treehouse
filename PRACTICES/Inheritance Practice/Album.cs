using System;
namespace Treehouse.MediaLibrary
{
    public class Album : MediaType
    {
        public readonly string Artist;
        public string Loanee;
        public bool OnLoan;

        public Album(string title, string artist) 
            : base(title)
        {
            Artist = artist;
        }
        }
    }
}
