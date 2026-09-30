using System.Net;
using Application.DTOs.Venues;
using Application.Interfaces;
using Application.Responses;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class VenueService(IVenueRepository venueRepository): IVenueService
{
    private readonly IVenueRepository repository = venueRepository;

    public async Task<ApiResponse<bool>> AddVenueAsync(CreateVenueDto venue)
    {
        var v = new Venue()
        {
            Name = venue.Name,
            Address = venue.Address,
            City = venue.City,
            Capacity = venue.Capacity
        };
        var res = await repository.AddVenueAsync(v);
        return res==true
            ? new ApiResponse<bool>(HttpStatusCode.OK, "Added.", res)
            : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Added", res);
    }
    public async Task<ApiResponse<List<VenueDto>>> GetVenuesAsync()
    {
        var res = await repository.GetVenuesAsync();
        var venues = res.Select(x=> new VenueDto()
        {
            Id = x.Id,
            Name = x.Name,
            Address = x.Address,
            City = x.City,
            Capacity = x.Capacity
        }).ToList();
        return new ApiResponse<List<VenueDto>>(HttpStatusCode.OK, "List of Venues", venues);
    }
    public async Task<ApiResponse<bool>> DeleteVenueAsync(int id)
    {
        var res = await repository.DeleteVenueAsync(id);
        return res == true
             ? new ApiResponse<bool>(HttpStatusCode.OK, "Deletes.", res)
            : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Deleted", res);
    }
}