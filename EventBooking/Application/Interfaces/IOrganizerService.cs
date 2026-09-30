using Application.DTOs.Organizers;
using Application.DTOs.Venues;
using Application.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IOrganizerService
{
    Task<ApiResponse<bool>> AddOrganizerAsync(CreateOrganizerDto organizer);
    Task<ApiResponse<List<OrganizerDto>>> GetOrganizerAsync();
    Task<ApiResponse<List<OrganizerWithEventsDto>>> GetVOrganizerWithEventsAsync();
}