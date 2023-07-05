using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_Library.Book;

namespace Task_Library
{
    internal class Library
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfBooks { get; set; }
        public List<Book> Books { get; set; }
        public List<Journal> Journals { get; set; }

        public Library(string name, string location)
        {
            Name = name;
            Location = location;
            NumberOfBooks = 0;
            Books = new List<Book>();
            Journals = new List<Journal>();
        }

        //Books
        public void ShowBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            }
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public void SearchBookByAuthor(string author)
        {
            bool bookFound = false;
            foreach (var book in Books)
            {
                if (book.Author == author)
                {
                    Console.WriteLine($"Search by author: {book.Name}");
                    bookFound = true;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book is not found");
            }
        }
        public void SearchBookByBookName(string name)
        {
            bool bookFound = false;
            foreach (var book in Books)
            {
                if (book.Name == name)
                {
                    Console.WriteLine($"Search by Book name: {book.Name}");
                    bookFound = true;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book is not found");
            }
        }
        public void SearchBookByYear(int year)
        {
            bool bookFound = false;
            foreach (var book in Books)
            {
                if (book.ReleaseDate == year)
                {
                    Console.WriteLine($"Search by year: {book.Name}");
                    bookFound = true;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book is not found");
            }
        }
        public void SearchBookByGenre(GenreEnum genre)
        {
            bool bookFound = false;
            foreach (var book in Books)
            {
                if (book.Genre == genre)
                {
                    Console.WriteLine($"Search by Book genre: {book.Name}");
                    bookFound = true;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book is not found");
            }
        }

        //Journal
        public void ShowJournals()
        {
            foreach (var journal in Journals)
            {
                Console.WriteLine(journal.Name);
            }
        }
        public void AddJournal(Journal journal)
        {
            Journals.Add(journal);
        }
        public void RemoveJournal(Journal journal)
        {
            Journals.Remove(journal);
        }
        public void SearchJournalByAuthor(string author)
        {
            bool journalFound = false;
            foreach (var journal in Journals)
            {
                if (journal.Author == author)
                {
                    Console.WriteLine($"Search by author: {journal.Name}");
                    journalFound = true;
                }
            }
            if (!journalFound)
            {
                Console.WriteLine("Journal is not found");
            }
        }
        public void SearchJournalByJournalName(string name)
        {
            bool journalFound = false;
            foreach (var journal in Journals)
            {
                if (journal.Name == name)
                {
                    Console.WriteLine($"Search by Book name: {journal.Name}");
                    journalFound = true;
                }
            }
            if (!journalFound)
            {
                Console.WriteLine("Journal is not found");
            }
        }
        public void SearchJournalByYear(int year)
        {
            bool journalFound = false;
            foreach (var journal in Journals)
            {
                if (journal.ReleaseDate == year)
                {
                    Console.WriteLine($"Search by year: {journal.Name}");
                    journalFound = true;
                }
            }
            if (!journalFound)
            {
                Console.WriteLine("Journal is not found");
            }
        }
        public void SearchJournalByGenre(GenreEnum genre)
        {
            bool journalFound = false;
            foreach (var journal in Journals)
            {
                if (journal.Genre == genre)
                {
                    Console.WriteLine($"Search by Book genre: {journal.Name}");
                    journalFound = true;
                }
            }
            if (!journalFound)
            {
                Console.WriteLine("Journal is not found");
            }
        }

    }
}
