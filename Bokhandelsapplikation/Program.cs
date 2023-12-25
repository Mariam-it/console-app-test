using Bokhandelsapplikation;

class Program
{
    static void Main(string[] args)
    {
        var bookStore = new BookStore();

        bookStore.AddBook(new Book("Bok 1", "Författare 1", "1234567890"));
        bookStore.AddBook(new Book("Bok 2", "Författare 2"));
        bookStore.AddBook(new Book("Bok 3", "Författare 3", "1234567891"));
        bookStore.AddBook(new Book("Bok 4", "Författare 4"));
        bookStore.AddBook(new Book("Bok 5", "Författare 5", "1234567490"));
        bookStore.AddBook(new Book("Bok 6", "Författare 6"));

        bookStore.ShowAllBooks();
        bookStore.ShowBook("Bok 1");

    }
}