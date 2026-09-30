using Domain.Entities;

namespace Domain.Repositoryes;

public interface IOrganizerRepository
{
    Task<bool> AddOrganizerAsync(Organizer organizer);
    Task<List<Organizer>> GetOrganizersAsync();
    Task<List<Organizer>> GetOrganizersWithEventsAsync(); 
}