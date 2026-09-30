using Application.DTOs.Attendees;
using Application.Responses;

namespace Application.Interfaces;

public interface IAttendeeService
{
    Task<ApiResponse<bool>> AddAttendeeAsync(CreateAttendeeDto attendee);
    Task<ApiResponse<List<AttendeeDto>>> GetAttendeeAsync();
    Task<ApiResponse<bool>> UpdateAttedeeAsync(AttendeeDto attendee);
}