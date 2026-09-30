using Application.DTOs.Venues;
using Application.Interfaces;
using Application.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class VenueController(IVenueService venueService) : ControllerBase
{
    private readonly IVenueService service = venueService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddVenueAsync(CreateVenueDto venue)
    {
        return await service.AddVenueAsync(venue);
    }

    [HttpGet]
    public async Task<ApiResponse<List<VenueDto>>> GetVenuesAsync()
    {
        return await service.GetVenuesAsync();
    }

    [HttpDelete("{id:int}")]
    public async Task<ApiResponse<bool>> DeleteVenueAsync(int id)
    {
        return await service.DeleteVenueAsync(id);
    }
}