namespace api.AuthorEndpoints;

public class CreateAuthorRequest
{
    public string? Name { get; set; }
    
    public string? Email { get; set; }
    
    public string? Website { get; set; }
}