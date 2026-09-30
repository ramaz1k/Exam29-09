
using Domain.Entities;
using Domain.Repositoryes;
using Domain.Repositoryes;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositoryes;

public class TicketRepository(AppDbContext appDbContext) : ITicketRepository
{
    private readonly AppDbContext context = appDbContext;
    public async Task<bool> AddTicketAsync(Ticket ticket)
    {
        context.Tickets.Add(ticket);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }

    public Task<List<Ticket>> GetTicketsAsync()
    {
        return context.Tickets.ToListAsync();
    }

}
