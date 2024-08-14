using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExpenseTracker.Infrastructure.Persistence;

public class ExpenseTrackerDbContext : DbContext
{
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Transfer> Transfers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
