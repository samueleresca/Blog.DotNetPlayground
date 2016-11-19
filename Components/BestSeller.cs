using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class BestSeller : ViewComponent
{
    private IBookService _service;
    public BestSeller(IBookService service)
    {
        _service = service;
    }
    public async Task<IViewComponentResult> InvokeAsync(int numberToTake)
    {
        var mostPopular = await _service.MostPopular(numberToTake);
        return View(mostPopular);
    }
}