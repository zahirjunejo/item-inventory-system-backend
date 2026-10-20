namespace ItemInventorySystemBackend.Models;

public class Player
{
    public int Id  { get; set; }
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string UserName { get; set; } 
    public string Password { get; set; }
}