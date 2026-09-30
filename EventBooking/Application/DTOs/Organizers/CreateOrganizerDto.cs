using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Organizers;

public class CreateOrganizerDto
{
    public string CompanyName{get;set;} = null!;
    public string ContactEmail{get;set;} = null!;
    public string? Phone{get;set;}
}