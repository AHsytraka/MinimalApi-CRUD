namespace Minimal_API_CRUD.Model;

public class User
{
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Username { get; set; }
}