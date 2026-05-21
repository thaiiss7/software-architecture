namespace DC.Models;

public class Hero : Base
{
    public required string Name {get;set;}
    public required string Description {get;set;}
    public required string Power {get;set;}
    public required string Status {get;set;} // Dead / Alive
}