using Application.DTOs.Attendees;
using Application.Interfaces;
using Application.Responses;
using Domain.Entities;
using Domain.Interfaces;
using System.Net;

namespace Application.Services;

public class AttendeeService(IAttendeeRepository attendeeRepository): IAttendeeService
{
    private readonly IAttendeeRepository repository = attendeeRepository;

    public async Task<ApiResponse<bool>> AddAttendeeAsync(CreateAttendeeDto attendee)
    {
        var a = new Attendee()
        {
            FullName = attendee.FullName,
            Email = attendee.Email
        };
        var res = await repository.AddAttendeeAsync(a);
        return res == true
            ? new ApiResponse<bool>(HttpStatusCode.OK, "Added.", res)
            : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Added", res);
    }

    public async Task<ApiResponse<List<AttendeeDto>>> GetAttendeeAsync()
    {
        var res = await repository.GetAttendeesAsync();
        var attendees = res.Select(x => new AttendeeDto()
        {
            Id = x.Id,
            FullName = x.FullName,
            Email = x.Email
        }).ToList();
        return new ApiResponse<List<AttendeeDto>>(HttpStatusCode.OK, "List of Attendees", attendees);
    }

    public async Task<ApiResponse<bool>> UpdateAttedeeAsync(AttendeeDto attendee)
    {
        var a = new Attendee()
        {
            Id = attendee.Id,
            FullName = attendee.FullName,
            Email = attendee.Email,
            RegisteredAt = DateTime.UtcNow
        };
        var res = await repository.UpdateAttendeeAsync(a);
        return res == true
            ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated.", res)
            : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Updated", res);
    }
}