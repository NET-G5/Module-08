using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Persistence.Configurations;

internal class TransferConfiguration : IEntityTypeConfiguration<Transfer>
{
    public void Configure(EntityTypeBuilder<Transfer> builder)
    {
        builder.ToTable(nameof(Transfer));

        builder.HasOne(t => t.Category)
            .WithMany(c => c.Transfers)
            .HasForeignKey(t => t.CategoryId);

        builder.Property(t => t.Title)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();
        builder.Property(t => t.Description)
            .HasMaxLength(Constants.MAX_STRING_LENGTH)
            .IsRequired(false);
        builder.Property(t => t.Amount)
            .HasPrecision(13, 2)
            .IsRequired();
    }
}
