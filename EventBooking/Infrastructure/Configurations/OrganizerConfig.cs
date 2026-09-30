using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;


public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
{
    public void Configure(EntityTypeBuilder<Organizer> builder)
    {
        builder.ToTable("Organizers");
        builder.HasKey(o => o.id);

        builder.HasMany(o => o.Events)
               .WithOne(e => e.Organizer)
               .HasForeignKey(e => e.OrganizerId);
    }
}