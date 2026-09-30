using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.ToTable("Tickets");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Code)
               .IsRequired();

        builder.Property(t => t.Price)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(t => t.PurchasedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .IsRequired();
    }
}