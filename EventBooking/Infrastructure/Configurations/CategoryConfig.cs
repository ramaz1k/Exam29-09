namespace Infrastructure.Configurations;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AttendeeProfileConfigurationDuplicate : IEntityTypeConfiguration<AttendeeProfile>
{
    public void Configure(EntityTypeBuilder<AttendeeProfile> builder)
    {
        builder.HasKey(ap => ap.AttendeeId);
        
        builder.HasOne(ap => ap.Attendee)
               .WithOne(a => a.Profile)
               .HasForeignKey<AttendeeProfile>(ap => ap.AttendeeId);
    }
}