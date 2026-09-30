namespace Application.DTOs.Tickets;

public class TicketDto
{
    public int Id {get; set;}
    public Guid Code {get; set;} = Guid.NewGuid();
    public decimal Price {get; set;}
    public DateTime PurchasedAt {get; set;}
    public bool IsCheckedIn {get; set;}
    public DateTime? CheckedInAt {get;set;}
}
