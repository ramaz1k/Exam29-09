using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("Events");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(e => e.UpdatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasOne(e => e.Venue)
               .WithMany(v => v.Events)
               .HasForeignKey(e => e.VenueId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Organizer)
               .WithMany(o => o.Events)
               .HasForeignKey(e => e.OrganizerId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.TicketTypes)
               .WithOne(tt => tt.Event)
               .HasForeignKey(tt => tt.EventId);

        builder.HasMany(e => e.Reviews)
               .WithOne(r => r.Event)
               .HasForeignKey(r => r.EventId);
    }
}