namespace Application.DTOs.Events;

public class EventDto
{
    public int Id{get;set;}
    public string Title{get;set;} = null!;
    public string? Descritpion{get;set;}
    public DateTime StartDate{get;set;}
    public DateTime EndDate{get;set;}
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
    public bool IsDeleted{get;set;}
}