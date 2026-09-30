using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.ToTable("Venues");
        builder.HasKey(v => v.id);

        builder.HasMany(v => v.Events)
               .WithOne(e => e.Venue)
               .HasForeignKey(e => e.VenueId)
               .OnDelete(DeleteBehavior.Restrict); 
    }
}