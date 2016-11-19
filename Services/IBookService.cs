using System.Collections.Generic;
using System.Threading.Tasks;

 public interface IBookService
{

    Task<List<Book>> MostPopular(int numberToTake);
}