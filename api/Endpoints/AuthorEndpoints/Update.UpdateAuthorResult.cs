namespace api.AuthorEndpoints;

public class UpdateAuthorResult
{
    public int Id { get; set; }

    public string? Name { get; set; }
    
    public string? Email { get; set; }
    
    public string? Website { get; set; }
}