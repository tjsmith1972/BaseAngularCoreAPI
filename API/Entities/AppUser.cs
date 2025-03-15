using System;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required string KnownAs { get; set; }
    public required string Gender { get; set; }
    public required string Password { get; set; }    
}
