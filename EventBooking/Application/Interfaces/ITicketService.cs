using Application.DTOs.Tickets;
using Application.Responses;

namespace Application.Interfaces;

public interface ITicketService
{
    Task<ApiResponse<bool>> AddTicketAsync(CreateTicketDto ticket);
    Task<ApiResponse<List<TicketDto>>> GetTicketsAsync();
}