using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_Library.Book;

namespace Task_Library
{
    internal class Journal
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public GenreEnum Genre { get; set; }
        public int NumberOfPage { get; set; }

        public Journal(string name, string author, int releaseDate, GenreEnum genre)
        {
                Name = name;
                Author = author;
                ReleaseDate = releaseDate;
                Genre = genre;
        }
        public enum JournalEnum
        {
            Reading,
            Review,
            Note,
            Quote,
            Recommendation
        }
    }
}
