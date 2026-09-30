using Application.DTOs.Events;
using Application.DTOs.Organizers;
using Application.Interfaces;
using Application.Responses;
using Domain.Entities;
using Domain.Interfaces;
using System.Net;

namespace Application.Services;

public class OrganizerServce(IOrganizerRepository organizerRepository): IOrganizerService
{
    private readonly IOrganizerRepository repository = organizerRepository;

    public async Task<ApiResponse<bool>> AddOrganizerAsync(CreateOrganizerDto organizer)
    {
        var o = new Organizer()
        {
            CompanyName = organizer.CompanyName,
            ContactEmail = organizer.ContactEmail,
            Phone = organizer.Phone
        };
        var res = await repository.AddOrganizerAsync(o);
                return res==true
                    ? new ApiResponse<bool>(HttpStatusCode.OK, "Added.", res)
                    : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Added", res);
    }

    public async Task<ApiResponse<List<OrganizerDto>>> GetOrganizerAsync()
    {
        var res = await repository.GetOrganizersAsync();
        var organizers = res.Select(x=> new OrganizerDto
        {
            Id = x.Id,
            CompanyName = x.CompanyName,
            ContactEmail = x.ContactEmail,
            Phone = x.Phone
        }).ToList();
        return new ApiResponse<List<OrganizerDto>>(HttpStatusCode.OK, "List of Organizers", organizers);
    }

    public async Task<ApiResponse<List<OrganizerWithEventsDto>>> GetVOrganizerWithEventsAsync()
    {
        var res = await repository.GetOrganizersWithEventsAsync();
        var organizers = res.Select(x=> new OrganizerWithEventsDto
        {
            Id = x.Id,
            CompanyName = x.CompanyName,
            ContactEmail = x.ContactEmail,
            Phone = x.Phone,
            Events = x.Events
                .Select(y=> new EventDto()
                {
                    Id = y.Id,
                    StartDate = y.StartDate,
                    EndDate = y.EndDate,
                    CreatedAt = y.CreatedAt,
                    UpdatedAt = y.UpdatedAt
                }).ToList()
        }).ToList();
        return new ApiResponse<List<OrganizerWithEventsDto>>(HttpStatusCode.OK, "List of Organizers", organizers);
    }
}