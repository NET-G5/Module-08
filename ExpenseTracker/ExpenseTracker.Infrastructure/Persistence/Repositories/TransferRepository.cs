using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Infrastructure.Persistence.Repositories;

public class TransferRepository : RepositoryBase<Transfer>, ITransferRepository
{
    public TransferRepository(ExpenseTrackerDbContext context) 
        : base(context)
    {
    }

    public List<Transfer> GetAll(string? search)
    {
        if (string.IsNullOrEmpty(search))
        {
            return GetAll();
        }

        var transfers = _context.Transfers
            .Where(x => x.Title.Contains(search) || 
                (x.Description != null && x.Description.Contains(search)))
            .ToList();

        return transfers;
    }

    public List<Transfer> GetAll(decimal minAmount, decimal maxAmount)
    {
        throw new NotImplementedException();
    }
}
