using Application.DTOs.Venues;
using Application.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IVenueService
{
    Task<ApiResponse<bool>> AddVenueAsync(CreateVenueDto venue);
    Task<ApiResponse<List<VenueDto>>> GetVenuesAsync();
    Task<ApiResponse<bool>> DeleteVenueAsync(int id);
}