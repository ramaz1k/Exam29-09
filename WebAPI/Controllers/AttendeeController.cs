using Application.DTOs.Attendees;
using Application.Interfaces;
using Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AttendeeController(IAttendeeService attendeeService):ControllerBase
{
    private readonly IAttendeeService service = attendeeService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddAttendeeAsync(CreateAttendeeDto attendee)
    {
        return await service.AddAttendeeAsync(attendee);
    }

    [HttpGet]
    public async Task<ApiResponse<List<AttendeeDto>>> GetAttendeesAsync()
    {
        return await service.GetAttendeeAsync();
    }

    [HttpPut]
    public async Task<ApiResponse<bool>> UpdateAttendeeAsync([FromQuery] AttendeeDto attendee)
    {
        return await service.UpdateAttedeeAsync(attendee);
    }
}
         
