using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Library
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public GenreEnum Genre { get; set; }
        public int NumberOfPage { get; set; }

        public Book(string name,string author,int releaseDate,GenreEnum genre)
        {
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
        }
        public enum GenreEnum
        {
            Mystery,
            ScienceFiction,
            Romance,
            Fantasy,
            Biography,
            Horror,
            Thriller,
            Comedy,
            Drama
        }

    }
}
