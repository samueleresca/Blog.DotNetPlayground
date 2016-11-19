using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BookService : IBookService
{

    private List<Book> bookList{get; set;}

    
    public BookService()
    {
        bookList = new List<Book>
        {
            new Book {BookId = 1, Author = "Kate Atkinson", Title = "A God In Ruins", Price = 7.99m },
            new Book {BookId = 2, Author = "Renee Knight", Title = "Disclaimer", Price = 7.99m },
            new Book {BookId = 3, Author = "James Patterson", Title = "Private Sydney", Price = 7.99m },
            new Book {BookId = 4, Author = "Michael Punke", Title = "The Revenant", Price = 7.99m },
            new Book {BookId = 5, Author = "Celia Imrie", Title = "Not Quite Nice", Price = 7.99m },
            new Book {BookId = 6, Author = "Harlan Coben", Title = "The Stranger", Price = 7.99m },
            new Book {BookId = 7, Author = "Emma Donoghue", Title = "Room", Price = 8.99m },
            new Book {BookId = 8, Author = "Laura Barnett", Title = "The Versions of Us", Price = 7.99m }
        };
    }
    public async Task<List<Book>> MostPopular(int numberToTake)
    {
        return await Task.FromResult(bookList.OrderBy(b => b.BookId).Take(numberToTake).ToList());
    }
}