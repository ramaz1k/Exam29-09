using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Organizer
{
    public int id { get; set; }
    [Required]
    [MaxLength(50)]
    public string CompanyName { get; set; }
    [Required]
    [MaxLength(100)]
    public string ContactEmail { get; set; }
    [MaxLength(50)]
    public string? Phone { get; set; }
    public ICollection<Event> Events {get;set;} = [];


}
