using Application.DTOs.Organizers;
using Application.Interfaces;
using Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OrganizerController(IOrganizerService organizerService): ControllerBase
{
    private readonly IOrganizerService service = organizerService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddOrganizerAsync(CreateOrganizerDto organizer)
    {
        return await service.AddOrganizerAsync(organizer);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<OrganizerDto>>> GetOrganizersAsync()
    {
        return await service.GetOrganizerAsync();
    }

    [HttpGet("with-events")]
    public async Task<ApiResponse<List<OrganizerWithEventsDto>>> GetVOrganizerWithEventsAsync()
    {
        return await service.GetVOrganizerWithEventsAsync();
    }
}