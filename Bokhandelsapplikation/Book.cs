using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhandelsapplikation;

internal class Book
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string? ISBN { get; set; } // ISBN kan vara null

    public Book(string title, string author, string? isbn = null)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}
