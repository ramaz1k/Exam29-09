using Application.DTOs.Events;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Organizers;

public class OrganizerWithEventsDto
{
    public int Id{get;set;}
    public string CompanyName{get;set;} = null!;
    public string ContactEmail{get;set;} = null!;
    public string? Phone{get;set;}
    
    public ICollection<EventDto> Events {get;set;} = [];
}