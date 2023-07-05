using Task_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library("My Library", "Library Location");

        //Book

        Book book1 = new Book("Crime and Punishment", "Fyodor Dostoyevsky", 1866,Book.GenreEnum.Thriller);
        library.AddBook(book1);
        Book book2 = new Book("The Brothers Karamazov", "Fyodor Dostoyevsky", 1880, Book.GenreEnum.Romance);
        library.AddBook(book2);
        Book book3 = new Book("Notes from Underground", "Fyodor Dostoyevsky", 1864, Book.GenreEnum.Biography);
        library.AddBook(book3);
        Book book4 = new Book("The Idiot", "Fyodor Dostoyevsky", 1869, Book.GenreEnum.Mystery);
        library.AddBook(book4);

        library.RemoveBook(book1);
        library.SearchBookByYear(1869);
        library.SearchBookByAuthor("Fyodor Dostoyevsky");
        library.SearchBookByBookName("The Idiot");
        library.SearchBookByGenre(Book.GenreEnum.Mystery);
        library.ShowBooks();

        //Journal

        Journal journal1 = new("Scientific Discoveries", "John Smith", 2023, Book.GenreEnum.ScienceFiction);
        library.AddJournal(journal1);
        Journal journal2 = new("Literary Insights", "Emily Johnson", 2022, Book.GenreEnum.Fantasy);
        library.AddJournal(journal2);
        Journal journal3 = new("Medical Breakthroughs", "Michael Davis", 2021, Book.GenreEnum.Mystery);
        library.AddJournal(journal3);
        Journal journal4 = new("Environmental Studies", "Sarah Thompson", 2020, Book.GenreEnum.Biography);
        library.AddJournal(journal4);

        library.RemoveJournal(journal1);
        library.SearchJournalByYear(2022);
        library.SearchJournalByAuthor("Emily Johnson");
        library.SearchJournalByJournalName("Environmental Studies");
        library.SearchJournalByGenre(Book.GenreEnum.Mystery);
        library.ShowJournals();
        Console.ReadLine();
    }
}