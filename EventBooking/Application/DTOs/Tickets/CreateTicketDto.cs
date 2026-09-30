namespace Application.DTOs.Tickets;

public class CreateTicketDto
{
    public Guid Code {get; set;}= Guid.NewGuid();
    public decimal Price {get; set;}
    public bool IsCheckedIn {get; set;}
    public DateTime? CheckedInAt {get;set;}
}
