using Domain.Entities;

namespace Domain.Repositoryes;

public interface IAttendeeRepository
{
    
    Task<bool> AddAttendeeAsync(Attendee attendee);
    Task<List<Attendee>> GetAttendeesAsync();
    Task<bool> UpdateAttendeeAsync(Attendee attendee);
}
