using Application.DTOs.Tickets;
using Application.Interfaces;
using Application.Responses;
using Domain.Entities;
using Domain.Interfaces;
using System.Net;

namespace Application.Services;

public class TicketService(ITicketRepository ticketRepository): ITicketService
{
    private readonly ITicketRepository repository = ticketRepository;

    public async Task<ApiResponse<bool>> AddTicketAsync(CreateTicketDto ticket)
    {
        var t = new Ticket()
        {
            Price = ticket.Price,
            IsCheckedIn = ticket.IsCheckedIn,
            CheckedInAt = ticket.CheckedInAt
        };
        var res = await repository.AddTicketAsync(t);
            return res==true
            ? new ApiResponse<bool>(HttpStatusCode.OK, "Added.", res)
            : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not Added", res);
    }

    public async Task<ApiResponse<List<TicketDto>>> GetTicketsAsync()
    {
       var res = await repository.GetTicketsAsync();
       var tickets = res.Select(x=> new TicketDto()
       {
           Id = x.Id,
           Code = x.Code,
           Price = x.Price,
           PurchasedAt = x.PurchasedAt,
           IsCheckedIn = x.IsCheckedIn,
           CheckedInAt = x.CheckedInAt
       }).ToList();
       return new ApiResponse<List<TicketDto>>(HttpStatusCode.OK, "List of tickets", tickets);
    }
}