using ExpenseTracker.Infrastructure.Persistence;
using ExpenseTracker.Infrastructure.Persistence.Repositories;
using ExpenseTracker.Stores;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers;
// expense.com/categories/index
public class CategoriesController : Controller
{
    private readonly ICategoryStore _store;

    public CategoriesController(ICategoryStore store)
    {
        var context = new ExpenseTrackerDbContext();
        var repository = new CategoryRepository(context);
        //

        //

        //
        _store = new CategoryStore(repository);
    }

    public IActionResult Index()
    {
        return View();
    }
}
