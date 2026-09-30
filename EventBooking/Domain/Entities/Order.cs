using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public int Id {get;set;}
    public int AttendeeId {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime? PaidAt {get;set;}
    public decimal TotalAmount {get;set;}
    public OrderStatus Status {get;set;}

    public Attendee Attendee {get;set;} = null!;
    public ICollection<Ticket> Tickets {get;set;} = [];
}
