namespace Domain.Entities;

public class Venue
{
public  int id {get;set;}
public string Name {get;set;}
public string Address {get;set;}
public string City {get;set;}
public int Capacity {get;set;}
public ICollection<Event>Events{get;set;}=new List<Event>();
}
