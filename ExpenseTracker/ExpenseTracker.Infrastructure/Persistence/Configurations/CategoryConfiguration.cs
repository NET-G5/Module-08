using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Persistence.Configurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));

        builder.HasMany(c => c.Transfers)
            .WithOne(t => t.Category)
            .HasForeignKey(t => t.CategoryId);

        builder.Property(c => c.Name)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();
        builder.Property(c => c.Description)
            .HasMaxLength(Constants.MAX_STRING_LENGTH)
            .IsRequired(false);

        builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Grocery",
                Description = "Monthly grocery expenses."
            },
            new Category
            {
                Id = 2,
                Name = "Community services",
                Description = "Monthly grocery expenses."
            },
            new Category
            {
                Id = 3,
                Name = "Salary",
                Description = "Regular Job income."
            },
            new Category
            {
                Id = 4,
                Name = "Other incomes",
                Description = "Side husstle."
            });
    }
}
