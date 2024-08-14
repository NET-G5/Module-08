using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Stores;

public interface ICategoryStore
{
    void Add(Category category);
}

public class CategoryStore : ICategoryStore
{
    private readonly ICategoryRepository _repository;

    public CategoryStore(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public void Add(Category category)
    {
        _repository.Create(category);
    }
}

public class NewCategoryStore : ICategoryStore
{
    public void Add(Category category)
    {
        throw new NotImplementedException();
    }
}
