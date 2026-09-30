using Domain.Entities;
using Domain.Repositoryes;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AttendeeRepository(AppDbContext appDbContext):IAttendeeRepository
{
    private readonly AppDbContext context = appDbContext;

    public async Task<bool> AddAttendeeAsync(Attendee attendee)
    {
        context.Attendees.Add(attendee);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }

    public async Task<List<Attendee>> GetAttendeesAsync()
    {
        return await context.Attendees.ToListAsync();
    }

    public async Task<bool> UpdateAttendeeAsync(Attendee attendee)
    {
         var a = await context.Attendees.SingleOrDefaultAsync(x=> x.Id == attendee.Id);
         if(a != null)
         {
             a.FullName = attendee.FullName;
             a.Email = attendee.Email;
         }
         var res = await context.SaveChangesAsync();
         return res > 0;
    }
}