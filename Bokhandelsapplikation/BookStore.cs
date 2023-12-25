using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhandelsapplikation;

internal class BookStore
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ShowAllBooks()
    {
        foreach (var book in books) 
        { 
            Console.WriteLine(book.Title);
        }
    }
    // Metod för att visa en specifik bok (exempelvis baserat på titel)
    public void ShowBook(string title)
    {
        var book = books.Find(b => b.Title == title);
        if (book != null) 
        { 
        Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
        }
        else
        {
            Console.WriteLine("Boken hittades inte.");
        }
    }
}
