namespace Infrastructure.Data;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Venue> Venues { get; set; }
    public DbSet<Organizer> Organizers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<TicketType> TicketTypes { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<AttendeeProfile> AttendeeProfiles { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     modelBuilder.ApplyConfigurationsFromAssembly(
        typeof(AppDbContext).Assembly
     );
     base.OnModelCreating(modelBuilder);


    }

}
