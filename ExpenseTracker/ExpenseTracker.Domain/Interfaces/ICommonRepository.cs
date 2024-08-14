namespace ExpenseTracker.Domain.Interfaces;

public interface ICommonRepository
{
    ICategoryRepository Categories { get; }
    ITransferRepository Transfers { get; }

    int SaveChanges();
}
