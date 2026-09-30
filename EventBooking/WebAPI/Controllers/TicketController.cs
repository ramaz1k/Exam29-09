using Application.DTOs.Tickets;
using Application.Interfaces;
using Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TicketController(ITicketService ticketService): ControllerBase
{
    private readonly ITicketService service = ticketService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddTicketAsync(CreateTicketDto ticket)
    {
        return await service.AddTicketAsync(ticket);
    }

    [HttpGet]
    public async Task<ApiResponse<List<TicketDto>>> GetTicketsAsync()
    {
        return await service.GetTicketsAsync();
    }
}